package es.luisherrero.apirest1.model;

import java.io.Serializable;
import java.util.Date;
import jakarta.persistence.*;

@Entity
@Table(name="equipos")
public class Equipo implements Serializable{
	private static final long serialVersionUID=1;
	@Id
	private int id;

	private byte baja;

	private String descripcion;

	private String etiqueta;

	@Column(name="fecha_adquisicion")
	private Date fechaAdquisicion;

	private String marca;

	private String modelo;

	private int puesto;
	
	//@Enumerated(EnumType.STRING)
	@Column(name="tipo_equipo")
	private String tipoEquipo;

	@Column(name = "aula_num")
	private int aula;

	public Equipo() {
	}

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public byte getBaja() {
		return this.baja;
	}

	public void setBaja(byte baja) {
		this.baja = baja;
	}

	public String getDescripcion() {
		return this.descripcion;
	}

	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}

	public String getEtiqueta() {
		return this.etiqueta;
	}

	public void setEtiqueta(String etiqueta) {
		this.etiqueta = etiqueta;
	}

	public Date getFechaAdquisicion() {
		return this.fechaAdquisicion;
	}

	public void setFechaAdquisicion(Date fechaAdquisicion) {
		this.fechaAdquisicion = fechaAdquisicion;
	}

	public String getMarca() {
		return this.marca;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public String getModelo() {
		return this.modelo;
	}

	public void setModelo(String modelo) {
		this.modelo = modelo;
	}

	public int getPuesto() {
		return this.puesto;
	}

	public void setPuesto(int puesto) {
		this.puesto = puesto;
	}

	public String getTipoEquipo() {
		return this.tipoEquipo;
	}

	public void setTipoEquipo(String tipoEquipo) {
		this.tipoEquipo = tipoEquipo;
	}

	public int getAula() {
		return this.aula;
	}

	public void setAula(int aula) {
		this.aula = aula;
	}
}
