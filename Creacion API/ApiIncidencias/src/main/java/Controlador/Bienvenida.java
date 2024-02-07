package Controlador;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class Bienvenida {
	@GetMapping("/welcome")
	public String welcome() {
		return "welcome";
	}
}
