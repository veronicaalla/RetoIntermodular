package es.luisherrero.apirest1.model;

import java.io.Serializable;

import jakarta.persistence.Column;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@jakarta.persistence.Entity
@Table(name="perfiles")
public class Perfiles implements Serializable{
	private static final long serialVersionUID=1;
	@Id
	@Column(name="personal_id")
	private int personal_id; 
	
	private String dominio;

	private String educantabria;

	private String password;

	@Enumerated(EnumType.STRING)
	private Tipo_Perfil perfil;

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

	public Tipo_Perfil getPerfil() {
		return this.perfil;
	}

	public void setPerfil(Tipo_Perfil perfil) {
		this.perfil = perfil;
	}

	/*public Personal getPersonal() {
		return this.personal;
	}

	public void setPersonal(Personal personal) {
		this.personal = personal;
	}*/

	public int getPersonal_id() {
		return personal_id;
	}

	public void setPersonal_id(int personal_id) {
		this.personal_id = personal_id;
	}
}
