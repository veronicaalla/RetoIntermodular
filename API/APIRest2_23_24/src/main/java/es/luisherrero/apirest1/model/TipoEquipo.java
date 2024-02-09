package es.luisherrero.apirest1.model;

public enum TipoEquipo {
	altavoces("altavoces"), impresora("impresora"), pantalla_interactiva("pantalla interactiva"),
	portátil_de_aula("portátil de aula"), portátil_cónsejeria("portátil Cónsejería"), proyector("proyector"),
	monitor("monitor");

	private String tipo;

	TipoEquipo() {
		this.tipo = "valor predeterminado";
	}

	TipoEquipo(String tipo) {
		this.tipo = tipo;
	}

	public String getTipo() {
		return tipo;
	}
}
