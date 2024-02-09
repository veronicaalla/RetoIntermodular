package es.luisherrero.apirest1.model;

import java.io.Serializable;
import java.util.List;

import jakarta.persistence.Column;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@jakarta.persistence.Entity
@Table(name="personal")
public class Personal implements Serializable{
	private static final long serialVersionUID=1;
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name="id")
	private Integer personal_id;

	private byte activo;

	private String apellido1;

	private String apellido2;

	private String cp;

	private String direccion;

	private String dni;

	private String localidad;

	private String nombre;

	private String tlf;
	
	// Unidireccional: Personal a Departamento
	@ManyToOne
	@JoinColumn(name="departamento_id")
	private Departamento departamento;

	public Personal() {
		super();
	}

	public Personal(byte activo, String apellido1, String apellido2, String cp, String direccion, String dni, String localidad, String nombre, String tlf, List<Comentario> comentarios,
			List<Incidencia> incidencias, List<Perfiles> perfiles, Departamento departamento) {
		super();
		this.activo = activo;
		this.apellido1 = apellido1;
		this.apellido2 = apellido2;
		this.cp = cp;
		this.direccion = direccion;
		this.dni = dni;
		this.localidad = localidad;
		this.nombre = nombre;
		this.tlf = tlf;
		//this.comentarios = comentarios;
		//this.incidencias = incidencias;
		//this.perfiles = perfiles;
		//this.departamento = departamento;
	}



	public int getId() {
		return this.personal_id;
	}

	public void setId(int id) {
		this.personal_id = id;
	}

	public byte getActivo() {
		return this.activo;
	}

	public void setActivo(byte activo) {
		this.activo = activo;
	}

	public String getApellido1() {
		return this.apellido1;
	}

	public void setApellido1(String apellido1) {
		this.apellido1 = apellido1;
	}

	public String getApellido2() {
		return this.apellido2;
	}

	public void setApellido2(String apellido2) {
		this.apellido2 = apellido2;
	}

	public String getCp() {
		return this.cp;
	}

	public void setCp(String cp) {
		this.cp = cp;
	}

	public String getDireccion() {
		return this.direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public String getDni() {
		return this.dni;
	}

	public void setDni(String dni) {
		this.dni = dni;
	}

	public String getLocalidad() {
		return this.localidad;
	}

	public void setLocalidad(String localidad) {
		this.localidad = localidad;
	}

	public String getNombre() {
		return this.nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getTlf() {
		return this.tlf;
	}

	public void setTlf(String tlf) {
		this.tlf = tlf;
	}

	/*public List<Comentario> getComentarios() {
		return this.comentarios;
	}

	public void setComentarios(List<Comentario> comentarios) {
		this.comentarios = comentarios;
	}

	public Comentario addComentario(Comentario comentario) {
		getComentarios().add(comentario);
		comentario.setPersonal(this);

		return comentario;
	}

	public Comentario removeComentario(Comentario comentario) {
		getComentarios().remove(comentario);
		comentario.setPersonal(null);

		return comentario;
	}

	public List<Incidencia> getIncidencias1() {
		return this.incidencias;
	}

	public void setIncidencias1(List<Incidencia> incidencias1) {
		this.incidencias = incidencias1;
	}

	public Incidencia addIncidencias1(Incidencia incidencias1) {
		getIncidencias1().add(incidencias1);
		incidencias1.setPersonal1(this);

		return incidencias1;
	}

	public Incidencia removeIncidencias1(Incidencia incidencias1) {
		getIncidencias1().remove(incidencias1);
		incidencias1.setPersonal1(null);

		return incidencias1;
	}

	public List<Perfiles> getPerfiles() {
		return this.perfiles;
	}

	public void setPerfiles(List<Perfiles> perfiles) {
		this.perfiles = perfiles;
	}

	public Perfiles addPerfile(Perfiles perfile) {
		getPerfiles().add(perfile);
		perfile.setPersonal(this);

		return perfile;
	}

	public Perfiles removePerfile(Perfiles perfile) {
		getPerfiles().remove(perfile);
		perfile.setPersonal(null);

		return perfile;
	}
*/
	public Departamento getDepartamento() {
		return this.departamento;
	}

	public void setDepartamento(Departamento departamento) {
		this.departamento = departamento;
	}
}
