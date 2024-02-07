package com.Equipo2;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class ApiIncidenciasApplication {

	public static void main(String[] args) {
		//HttpClient httpClient=HttpClient.newBuilder().version(HttpClient.Version)
				SpringApplication.run(ApiIncidenciasApplication.class, args);
	}
}
