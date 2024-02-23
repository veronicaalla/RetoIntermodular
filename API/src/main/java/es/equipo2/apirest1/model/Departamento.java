package es.equipo2.apirest1.model;

import java.io.Serializable;

import jakarta.persistence.Column;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@jakarta.persistence.Entity
@Table(name="departamentos")
public class Departamento implements Serializable{
	private static final long serialVersionUID=1;
	@Id
	@Column(name="id")
	private int int_;

	private boolean activo;

	private String cod;

	private String nombre;

	// En la clase Departamento
	@Column(name="jefedep_id")
	private int jefedep_id;

	public Departamento() {
	}

	public int getInt_() {
		return this.int_;
	}

	public void setInt_(int int_) {
		this.int_ = int_;
	}

	public boolean getActivo() {
		return this.activo;
	}

	public void setActivo(boolean activo) {
		this.activo = activo;
	}

	public String getCod() {
		return this.cod;
	}

	public void setCod(String cod) {
		this.cod = cod;
	}

	public String getNombre() {
		return this.nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public int getPersonal() {
			return this.jefedep_id;
	}

	public void setPersonal(int personal) {
		this.jefedep_id = personal;
	}
}