package Modelo;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the perfiles database table.
 * 
 */
@Entity
@Table(name="perfiles")
@NamedQuery(name="Perfile.findAll", query="SELECT p FROM Perfiles p")
public class Perfiles implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int personal_id; 
	
	private String dominio;

	private String educantabria;

	private String password;

	private String perfil;

	//bi-directional many-to-one association to Personal
	@ManyToOne
	private Personal personal;

	public Perfiles() {
	}

	public String getDominio() {
		return this.dominio;
	}

	public void setDominio(String dominio) {
		this.dominio = dominio;
	}

	public String getEducantabria() {
		return this.educantabria;
	}

	public void setEducantabria(String educantabria) {
		this.educantabria = educantabria;
	}

	public String getPassword() {
		return this.password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getPerfil() {
		return this.perfil;
	}

	public void setPerfil(String perfil) {
		this.perfil = perfil;
	}

	public Personal getPersonal() {
		return this.personal;
	}

	public void setPersonal(Personal personal) {
		this.personal = personal;
	}

	public int getPersonal_id() {
		return personal_id;
	}

	public void setPersonal_id(int personal_id) {
		this.personal_id = personal_id;
	}
	
	

}