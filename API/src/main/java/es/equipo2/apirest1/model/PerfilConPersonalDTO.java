package es.equipo2.apirest1.model;

public class PerfilConPersonalDTO {
    private Perfiles perfil;
    private Personal personal;

    // Constructor
    public PerfilConPersonalDTO() {
    }

    // Constructor con parámetros
    public PerfilConPersonalDTO(Perfiles perfil, Personal personal) {
        this.perfil = perfil;
        this.personal = personal;
    }

    // Getters y setters
    public Perfiles getPerfil() {
        return perfil;
    }

    public void setPerfil(Perfiles perfil) {
        this.perfil = perfil;
    }

    public Personal getPersonal() {
        return personal;
    }

    public void setPersonal(Personal personal) {
        this.personal = personal;
    }
}


