package es.intermodular.equipo2.incidenciasies

import android.content.res.Configuration
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding
import java.util.Locale

class Principal : AppCompatActivity() {

    private lateinit var binding : ActivityPrincipalBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityPrincipalBinding.inflate(layoutInflater)
        setContentView(binding.root)

        fun changeLanguage(view: View) {
            // Cambiar el idioma de la aplicación aquí
            // Por ejemplo, para cambiar al inglés:
            val locale = Locale("en")
            Locale.setDefault(locale)
            val config = Configuration()
            config.locale = locale
            baseContext.resources.updateConfiguration(config, baseContext.resources.displayMetrics)

            // Reiniciar la actividad para aplicar el cambio de idioma
            recreate()
        }
    }
}