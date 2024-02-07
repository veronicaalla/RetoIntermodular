package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import android.content.SharedPreferences
import android.content.res.Configuration
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Toast
import es.intermodular.equipo2.incidenciasies.databinding.ActivityLogginBinding

import java.util.Locale

class LoginActivity : AppCompatActivity() {

    // Variable utilizada para acceder a las vistas del layout de la actividad mediante View Binding
    private lateinit var binding: ActivityLogginBinding

    // Objeto utilizado para almacenar datos de manera persistente, como las preferencias del usuario
    private lateinit var sharedPref: SharedPreferences

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityLogginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        // Inicialización de SharedPreferences para guardar datos persistentes
        sharedPref = getSharedPreferences("pref", MODE_PRIVATE)

        // Obtener el idioma actual almacenado en SharedPreferences, por defecto es español
        val currentLanguage = sharedPref.getString("language", "es") ?: "es"
        // Configurar el idioma de la aplicación según el idioma almacenado
        setAppLanguage(currentLanguage)

        val checkBoxRecordarme = binding.checkBoxRecordarme

        // Configurar el OnClickListener para el botón de inicio de sesión
        binding.btnIniciarSesion.setOnClickListener {
            // Obtener el texto ingresado en los campos de usuario y contraseña
            val usuario = binding.EditTextUsuario.text.toString()
            val contrasenia = binding.EditTextContrasenia.text.toString()

            // Verificar si ambos campos están vacíos
            if (usuario.isEmpty() || contrasenia.isEmpty()) {
                // Mostrar mensaje de error dependiendo del idioma actual
                val errorMessage = if (currentLanguage == "es") "¡Por favor, rellene ambos campos!" else "Please fill in both fields!"
                showToast(errorMessage)
            } else {
                // Si ambos campos tienen datos, continuar con la lógica de inicio de sesión
                if (validateUser(usuario) && contrasenia == "123") {
                    // Mensaje de bienvenida
                    val welcomeMessage = if (currentLanguage == "es") "¡Bienvenido!" else "Welcome!"
                    showToast(welcomeMessage)
                    // Iniciar actividad principal
                    startActivity(Intent(this, Principal::class.java))
                } else {
                    // Mensaje de error de inicio de sesión
                    val errorMessage = if (currentLanguage == "es") "¡Usuario o contraseña incorrectos!" else "Invalid username or password!"
                    showToast(errorMessage)
                }
            }
        }

        val editor = sharedPref.edit()

        // Configurar el Listener para el CheckBox para recordar datos
        checkBoxRecordarme.setOnCheckedChangeListener { _, isChecked ->
            if (isChecked) {
                // Guardar datos en SharedPreferences si el CheckBox está marcado
                editor.putString("usuario", binding.EditTextUsuario.text.toString())
                editor.putString("contrasenia", binding.EditTextContrasenia.text.toString())
                editor.putBoolean("recordarme", true)
            } else {
                // Eliminar datos de SharedPreferences si el CheckBox no está marcado
                editor.remove("usuario")
                editor.remove("contrasenia")
                editor.remove("recordarme")
            }
            editor.apply() // Aplicar los cambios en SharedPreferences
        }

        // Recuperar y establecer datos si la opción de recordar está habilitada
        val recordarme = sharedPref.getBoolean("recordarme", false)
        if (recordarme) {
            val usuarioGuardado = sharedPref.getString("usuario", "")
            val contraseniaGuardada = sharedPref.getString("contrasenia", "")
            binding.EditTextUsuario.setText(usuarioGuardado)
            binding.EditTextContrasenia.setText(contraseniaGuardada)
            checkBoxRecordarme.isChecked = true
        }
    }

    override fun onStop() {
        super.onStop()
        // Guardar datos en SharedPreferences al salir de la actividad
        val editor = sharedPref.edit()
        if (binding.checkBoxRecordarme.isChecked) {
            editor.putString("usuario", binding.EditTextUsuario.text.toString())
            editor.putString("contrasenia", binding.EditTextContrasenia.text.toString())
            editor.putBoolean("recordarme", true)
        } else {
            editor.remove("usuario")
            editor.remove("contrasenia")
            editor.remove("recordarme")
        }
        editor.apply() // Aplicar los cambios en SharedPreferences
    }

    // Método para validar el formato del usuario
    private fun validateUser(usuario: String): Boolean {
        val regex = Regex("^[a-zA-Z0-9._%+-]+@(educantabria\\.es|iesmiguelherrero\\.com)$")
        return regex.matches(usuario)
    }

    // Método para cambiar el idioma de la aplicación
    fun changeLanguage(view: View) {
        // Obtener el idioma actual almacenado en SharedPreferences
        val currentLanguage = sharedPref.getString("language", "es") ?: "es"
        // Cambiar el idioma actual a inglés si era español, o viceversa
        val newLanguage = if (currentLanguage == "es") "en" else "es"
        // Configurar el nuevo idioma y guardarlo en SharedPreferences
        setAppLanguage(newLanguage)
        with(sharedPref.edit()) {
            putString("language", newLanguage)
            apply()
        }
        // Recrear la actividad para aplicar los cambios de idioma
        recreate()
    }

    // Método para configurar el idioma de la aplicación
    private fun setAppLanguage(language: String) {
        val locale = Locale(language)
        Locale.setDefault(locale)
        val configuration = Configuration()
        configuration.setLocale(locale)
        resources.updateConfiguration(configuration, baseContext.resources.displayMetrics)
    }

    // Método para mostrar un mensaje Toast
    private fun showToast(message: String) {
        Toast.makeText(this, message, Toast.LENGTH_SHORT).show()
    }

}