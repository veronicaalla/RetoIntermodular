package es.luisherrero.apirest1.model;

import java.io.Serializable;
import java.sql.Time;
import java.util.Date;

import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@jakarta.persistence.Entity
@Table(name = "incidencias")
public class Incidencia implements Serializable {
	private static final long serialVersionUID = 1;

	@Id
	private int num;

	private String adjuntoUrl;

	private String descripcion;

	@Enumerated(EnumType.STRING)
	private Estado_Incidencia estado;

	private Date fechaCierre;

	private Date fechaCreacion;

	private Time tiempo_dec;
	
	@Enumerated(EnumType.STRING)
	private Tipo_Incidencias tipo;

	// private List<Comentario> comentarios;

	@ManyToOne
	//@Column(name = "equipo_id")
	private Equipo equipo;

	@ManyToOne
	@JoinColumn(name="subtipo_id")
	private IncidenciasSubtipo incidenciasSubtipo;

	@ManyToOne
	private Personal creador;

	@ManyToOne
	private Personal responsable;

	public Incidencia() {
	}

	public int getNum() {
		return this.num;
	}

	public void setNum(int num) {
		this.num = num;
	}

	public String getAdjuntoUrl() {
		return this.adjuntoUrl;
	}

	public void setAdjuntoUrl(String adjuntoUrl) {
		this.adjuntoUrl = adjuntoUrl;
	}

	public String getDescripcion() {
		return this.descripcion;
	}

	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}

	public Estado_Incidencia getEstado() {
		return this.estado;
	}

	public void setEstado(Estado_Incidencia estado) {
		this.estado = estado;
	}

	public Date getFechaCierre() {
		return this.fechaCierre;
	}

	public void setFechaCierre(Date fechaCierre) {
		this.fechaCierre = fechaCierre;
	}

	public Date getFechaCreacion() {
		return this.fechaCreacion;
	}

	public void setFechaCreacion(Date fechaCreacion) {
		this.fechaCreacion = fechaCreacion;
	}

	public Tipo_Incidencias getTipo() {
		return this.tipo;
	}

	public void setTipo(Tipo_Incidencias tipo) {
		this.tipo = tipo;
	}

	/*
	 * public List<Comentario> getComentarios() { return this.comentarios; }
	 * 
	 * public void setComentarios(List<Comentario> comentarios) { this.comentarios =
	 * comentarios; }
	 * 
	 * public Comentario addComentario(Comentario comentario) {
	 * getComentarios().add(comentario); comentario.setIncidencia(this);
	 * 
	 * return comentario; }
	 * 
	 * public Comentario removeComentario(Comentario comentario) {
	 * getComentarios().remove(comentario); comentario.setIncidencia(null);
	 * 
	 * return comentario;
	 */
	public Equipo getEquipo() {
		return this.equipo;
	}

	public void setEquipo(Equipo equipo) {
		this.equipo = equipo;
	}

	public IncidenciasSubtipo getIncidenciasSubtipo() {
		return this.incidenciasSubtipo;
	}

	public void setIncidenciasSubtipo(IncidenciasSubtipo incidenciasSubtipo) {
		this.incidenciasSubtipo = incidenciasSubtipo;
	}

	public Personal getCreador() {
		return this.creador;
	}

	public void setCreador(Personal creador) {
		this.creador = creador;
	}

	public Personal getResponsable() {
		return this.responsable;
	}

	public void setResponsable(Personal creador) {
		this.responsable = creador;
	}

	public Time getTiempo_dec() {
		return tiempo_dec;
	}

	public void setTiempo_dec(Time tiempo_dec) {
		this.tiempo_dec = tiempo_dec;
	}
	
	
}
