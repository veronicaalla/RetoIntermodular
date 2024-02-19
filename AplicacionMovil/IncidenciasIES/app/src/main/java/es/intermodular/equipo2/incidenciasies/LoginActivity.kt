package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import android.content.SharedPreferences
import android.content.res.Configuration
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Toast
import es.intermodular.equipo2.incidenciasies.databinding.ActivityLoginBinding

import java.util.Locale

class LoginActivity : AppCompatActivity() {

    // Variable utilizada para acceder a las vistas del layout de la actividad mediante View Binding
    private lateinit var binding: ActivityLoginBinding

    // Objeto utilizado para almacenar datos de manera persistente, como las preferencias del usuario
    private lateinit var sharedPref: SharedPreferences

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        // Inicialización de SharedPreferences para guardar datos persistentes
        sharedPref = getSharedPreferences("pref", MODE_PRIVATE)

        val checkBoxRecordarme = binding.checkBoxRecordarme

        // Configurar el OnClickListener para el botón de inicio de sesión
        binding.btnIniciarSesion.setOnClickListener {
            // Obtener el texto ingresado en los campos de usuario y contraseña
            val usuario = binding.EditTextUsuario.text.toString()
            val contrasenia = binding.EditTextContrasenia.text.toString()

            // Verificar si ambos campos están vacíos
            if (usuario.isEmpty() || contrasenia.isEmpty()) {
                // Mostrar mensaje de error
                showToast("¡Por favor, rellene ambos campos!")
            } else {
                // Si ambos campos tienen datos, continuar con la lógica de inicio de sesión
                if (validateUser(usuario) && contrasenia == "123") {
                    // Mensaje de bienvenida
                    showToast("¡Bienvenido!")
                    // Iniciar actividad principal
                    startActivity(Intent(this, Principal::class.java))
                } else {
                    // Mensaje de error de inicio de sesión
                    showToast("¡Usuario o contraseña incorrectos!")
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
        // Configurar el OnClickListener para el TextView de olvidé contraseña
        binding.textViewOlvideContr.setOnClickListener {
            // Mostrar mensaje de olvidé contraseña
            showToast("Por favor, póngase en contacto con su coordinador TIC")
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
        val regex = Regex("^[a-zA-Z0-9._%+-]+@(educantabria\\.es)$")
        return regex.matches(usuario)
    }

    // Método para mostrar un mensaje Toast
    private fun showToast(message: String) {
        Toast.makeText(this, message, Toast.LENGTH_SHORT).show()
    }

}