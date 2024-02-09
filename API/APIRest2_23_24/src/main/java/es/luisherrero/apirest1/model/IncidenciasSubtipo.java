package es.luisherrero.apirest1.model;

import java.io.Serializable;
import java.util.List;

import jakarta.persistence.Column;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@jakarta.persistence.Entity
@Table(name="incidencias_subtipos")
public class IncidenciasSubtipo implements Serializable{
	private static final long serialVersionUID=1;
	@Id
	@Column(name="id")
	private int incidenciasSubtipo_id;

	@Column(name="sub_subtipo")
	private String subSubtipo;

	@Column(name="subtipo_nombre")
	private String subtipoNombre;

	private String tipo;

	public IncidenciasSubtipo() {
	}

	public int getId() {
		return this.incidenciasSubtipo_id;
	}

	public void setId(int id) {
		this.incidenciasSubtipo_id = id;
	}

	public String getSubSubtipo() {
		return this.subSubtipo;
	}

	public void setSubSubtipo(String subSubtipo) {
		this.subSubtipo = subSubtipo;
	}

	public String getSubtipoNombre() {
		return this.subtipoNombre;
	}

	public void setSubtipoNombre(String subtipoNombre) {
		this.subtipoNombre = subtipoNombre;
	}

	public String getTipo() {
		return this.tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}
}
