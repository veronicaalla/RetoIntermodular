package es.equipo2.apirest1.controller;

public class FileDownloadResponse {
	private byte[] archivoCodificado;
    private String extension;

    public FileDownloadResponse() {
    }

    public FileDownloadResponse(byte[] archivoCodificado, String extension) {
        this.archivoCodificado = archivoCodificado;
        this.extension = extension;
    }

    public byte[] getArchivoCodificado() {
        return archivoCodificado;
    }

    public void setArchivoCodificado(byte[] archivoCodificado) {
        this.archivoCodificado = archivoCodificado;
    }

    public String getExtension() {
        return extension;
    }

    public void setExtension(String extension) {
        this.extension = extension;
    }
}
