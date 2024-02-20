# Proyecto Intermodular

## Personal-controlador
En esta imagen se pueden ver algunos metodos del controlador personal; ya se mostrar, modificar o eliminar.

- __GET(/api/personal/{id})__: Muestra los datos de un elemento personal introduciendo un id.
- __PUT(/api/personal/{id})__: Modifica un elemento personal introduciendo un id.
- __DELETE(/api/personal/{id})__: Elimina un elemento personal introduciendo un id.
- __GET(/api/personal)__: Muestra los datos de todos los elementos personal.
- __POST(/api/personal)__: Crea un nuevo elemento personal introduciendo un id.
- __GET(/api/personal/nombre/{nombre})__: Muestra el nombre de todos los elementos personal introduciendo un nombre.
- __GET(/api/personal/apellido2/{apellido})__: Muestra el segundo apellido de todos los elementos personal introduciendo un apellido.
- __GET(/api/personal/apellido1/{apellido})__: Muestra el primer apellido de un elemento personal introduciendo un apellido.
- __DELETE(/api/personal/borrar_usuario/{idUsuario})__: Elimina un elemento personal introduciendo un id desde borrar_usuario.

![Imagen](Python_e_imagenes/API/personal_controlador.PNG)

___

## Personal-controlador(GET(/api/personal/{id}))
En esta imagen se muestra como se usa el metodo buscar personal por id.

![Imagen](Python_e_imagenes/API/get_api_personal_id.PNG)

___

## Personal-controlador(PUT(/api/personal/{id}))
En esta imagen se muestra como se usa el metodo modificar personal por id.

![Imagen](Python_e_imagenes/API/put_api_personal_id.PNG)

___

## Personal-controlador(DELETE(/api/personal/{id}))
En esta imagen se muestra como se usa el metodo eliminar personal por id.

![Imagen](Python_e_imagenes/API/delete_api_personal_id.PNG)

___

## Personal-controlador(GET(/api/personal))
En esta imagen se muestra como se usa el metodo mostrar personal.

![Imagen](Python_e_imagenes/API/get_api_personal.PNG)

___

## Personal-controlador(POST(/api/personal))
En esta imagen se muestra como funciona el metodo crear personal.

![Imagen](Python_e_imagenes/API/post_api_personal.PNG)

___

## Personal-controlador(GET(/api/personal/nombre/{nombre}))
En esta imagen se muestra como se usa el metodo buscar por nombre.

![Imagen](Python_e_imagenes/API/get_api_personal_nombre_nombre.PNG)

___

## Personal-controlador(GET(/api/personal/apellido2/{apellido}))
En esta imagen se muestra como se usa el metodo buscar por apellido2.

![Imagen](Python_e_imagenes/API/get_api_personal_apellido2_apellido.PNG)

___

## Personal-controlador(GET(/api/personal/apellido1/{apellido}))
En esta imagen se muestra como se usa el metodo buscar por apellido1.

![Imagen](Python_e_imagenes/API/get_api_personal_apellido1_apellido.PNG)

___

## Personal-controlador(DELETE(/api/personal/borrar_usuario/{idUsuario}))
En esta imagen se muestra como se usa el metodo borrar personal por idUsuario. Este metodo tambien requiere id de Administrador y contraseña de Administrador.

![Imagen](Python_e_imagenes/API/delete_api_personal_borrar-usuario_idUsuario.PNG)

___

## Perfiles-controlador
En esta imagen se pueden ver algunos metodos del controlador perfiles; ya se mostrar, modificar o eliminar.

- __GET(/api/perfiles/{id})__: Muestra los datos de un elemento perfil introduciendo un id.
- __PUT(/api/perfiles/{id})__: Modifica un elemento perfil introduciendo un id.
- __DELETE(/api/perfiles/{id})__: Elimina un elemento perfil introduciendo un id.
- __GET(/api/perfiles)__: Muestra los datos de todos los elementos perfil.
- __POST(/api/perfiles)__: Crea un nuevo elemento perfil introduciendo un id.
- __GET(/api/perfiles/tipo/{perfil})__: Muestra el tipo perfil de todos los elementos perfil introduciendo un perfil.
- __GET(/api/perfiles/dominio/{dominio})__: Muestra el dominio de todos los elementos perfil introduciendo un dominio.

![Imagen](Python_e_imagenes/API/perfiles_controlador.PNG)

___

## Perfil-controlador(GET(/api/perfiles/tipo/{perfil}))
En esta imagen se muestra como se usa el metodo buscar tipo de perfil por perfil.

![Imagen](Python_e_imagenes/API/get_api_perfiles_tipo_perfil.PNG)

___

## Perfil-controlador(GET(/api/perfiles/dominio/{dominio}))
En esta imagen se muestra como se usa el metodo buscar dominio de perfil por dominio.

![Imagen](Python_e_imagenes/API/get_api_perfiles_dominio_dominio.PNG)

___

## Incidencias-subtipo-controlador
En esta imagen se pueden ver algunos metodos del controlador incidencias-subtipo; ya se mostrar, modificar o eliminar.

- __GET(/api/incidencias-subtipos/{id})__: Muestra los datos de un elemento incidencias-subtipos introduciendo un id.
- __PUT(/api/incidencias-subtipos/{id})__: Modifica un elemento incidencias-subtipos introduciendo un id.
- __DELETE(/api/incidencias-subtipos/{id})__: Elimina un elemento incidencias-subtipos introduciendo un id.
- __GET(/api/incidencias-subtipos)__: Muestra los datos de todos los elementos incidencias-subtipos.
- __POST(/api/incidencias-subtipos)__: Crea un nuevo elemento incidencias-subtipos introduciendo un id.
- __GET(/api/incidencias-subtipos/tipo/{tipo})__: Muestra el tipo de todos los elementos incidencias-subtipos introduciendo un tipo de incidencia.

![Imagen](Python_e_imagenes/API/incidencias-subtipo_controlador.PNG)

___

## Incidencias-subtipo-controlador(GET(/api/incidencias-subtipos/tipo/{tipo}))
En esta imagen se muestra como se usa el metodo buscar tipo de incidencia-subtipo por tipo de incidencia.

![Imagen](Python_e_imagenes/API/get_api_incidencias-subtipos_tipo_tipo.PNG)

___

## Incidencias-controlador
En esta imagen se pueden ver algunos metodos del controlador personal; ya se mostrar, modificar o eliminar.

- __GET(/api/incidencias/{num})__: Muestra los datos de un elemento personal introduciendo un id.
- __PUT(/apiincidencias/{num})__: Modifica un elemento incidencias introduciendo un num.
- __DELETE(/api/incidencias/{num})__: Elimina un elemento incidencias introduciendo un num.
- __GET(/api/incidencias)__: Muestra los datos de todos los elementos incidencias.
- __POST(/api/incidencias)__: Crea un nuevo elemento incidencias.
- __GET(/api/incidencias/tipo/{tipo})__: Muestra el tipo de todos los elementos incidencias introduciendo un tipo de incidencias.
- __GET(/api/incidencias/responsable/{id})__: Muestra el responsable de todos los elementos incidencias introduciendo un id de responsable.
- __GET(/api/incidencias/fecha-creacion/{fechaCreacion})__: Muestra la fecha de creacion de todos los elementos incidencias introduciendo una fecha de creacion.
- __GET(/api/incidencias/fecha-cierre/{fechaCierre})__: Muestra la fecha de cierre de todos los elementos incidencias introduciendo una fecha de cierre. 
- __GET(/api/incidencias/fecha-estado/{estado})__: Muestra el estado de todos los elementos incidencias introduciendo un estado.
- __GET(/api/incidencias/creador/{id})__: Muestra el creador de todos los elementos incidencias introduciendo un id de creador.
- __GET(/api/incidencias/buscar)__: Muestra un buscador de incidencias.

![Imagen](Python_e_imagenes/API/incidencia_controlador.PNG)

___

## Incidencias-controlador(GET(/api/incidencias/tipo/{tipo}))
En esta imagen se muestra como se usa el metodo buscar por tipo de incidencia.

![Imagen](Python_e_imagenes/API/get_api_incidencias_tipo_tipo.PNG)

___

## Incidencias-controlador(GET(/api/incidencias/responsable/{id}))
En esta imagen se muestra como se usa el metodo buscar por id de responsable.

![Imagen](Python_e_imagenes/API/get_api_incidencias_responsable_id.PNG)

___

## Incidencias-controlador(GET(/api/incidencias/fecha-creacion/{fechaCreacion}))
En esta imagen se muestra como se usa el metodo buscar fecha por fecha de creacion.

![Imagen](Python_e_imagenes/API/get_api_incidencias_fecha-creacion_fechaCreacion.PNG)

___

## Incidencias-controlador(GET(/api/incidencias/fecha-cierre/{fechaCierre}))
En esta imagen se muestra como se usa el metodo buscar fecha por fecha de cierre.

![Imagen](Python_e_imagenes/API/get_api_incidencias_fecha-cierre_fechaCierre.PNG)

___

## Incidencias-controlador(GET(/api/incidencias/estado/{estado}))
En esta imagen se muestra como se usa el metodo buscar por estado.

![Imagen](Python_e_imagenes/API/get_api_incidencias_estado_estado.PNG)

___

## Incidencias-controlador(GET(/api/incidencias/creador/{id}))
En esta imagen se muestra como se usa el metodo buscar por id de creador.

![Imagen](Python_e_imagenes/API/get_api_incidencias_creador_id.PNG)

___

## Equipo-controlador
En esta imagen se pueden ver algunos metodos del controlador equipo; ya se mostrar, modificar o eliminar.

- __GET(/api/equipos/{id})__: Muestra los datos de un elemento equipo introduciendo un id.
- __PUT(/api/equipos/{id})__: Modifica un elemento equipo introduciendo un id.
- __DELETE(/api/equipos/{id})__: Elimina un elemento equipo introduciendo un id.
- __GET(/api/equipos)__: Muestra los datos de todos los elementos equipo.
- __POST(/api/equipos)__: Crea un nuevo elemento equipo introduciendo un id.

![Imagen](Python_e_imagenes/API/equipo_controlador.PNG)
___

## Departamento-controlador
En esta imagen se pueden ver algunos metodos del controlador departamento; ya se mostrar, modificar o eliminar.

- __GET(/api/departamentos/{id})__: Muestra los datos de un elemento departamento introduciendo un id.
- __PUT(/api/departamentos/{id})__: Modifica un elemento departamento introduciendo un id.
- __DELETE(/api/departamentos/{id})__: Elimina un elemento departamento introduciendo un id.
- __GET(/api/departamentos)__: Muestra los datos de todos los elementos departamento.
- __POST(/api/departamentos)__: Crea un nuevo elemento departamento introduciendo un id.

![Imagen](Python_e_imagenes/API/departamento_controlador.PNG)

___

## Comentario-controlador
En esta imagen se pueden ver algunos metodos del controlador comentario; ya se mostrar, modificar o eliminar.

- __GET(/api/comentarios/{id})__: Muestra los datos de un elemento comentario introduciendo un id.
- __PUT(/api/comentarios/{id})__: Modifica un elemento comentario introduciendo un id.
- __DELETE(/api/comentarios/{id})__: Elimina un elemento comentario introduciendo un id.
- __GET(/api/comentarios)__: Muestra los datos de todos los elementos comentario.
- __POST(/api/comentarios)__: Crea un nuevo elemento comentario introduciendo un id.

![Imagen](Python_e_imagenes/API/comentario_controlador.PNG)

___

## aula-controlador
En esta imagen se pueden ver algunos metodos del controlador aula; ya se mostrar, modificar o eliminar.

- __PUT(/api/aula/aula/{num})__: Modifica un elemento aula introduciendo un num.
- __DELETE(/api/aula/aula/{num})__: Elimina un elemento aula introduciendo un num.
- __POST(/api/aula/aula)__: Crea un nuevo elemento aula.
- __GET(/api/aula)__: Muestra los datos de un elemento aula introduciendo un num.
- __GET(/api/aula/{num})__: Muestra el num de todos los elementos aula introduciendo un num.
- __GET(/api/aula/planta/{planta})__: Muestra la planta de todos los elementos aula introduciendo una planta.

![Imagen](Python_e_imagenes/API/aula_controlador.PNG)

___


















# Encabezado1
## Encabezado2
### Encabezado3
#### Encabezado4
##### Encabezado5
###### Encabezado6

Subrayado 1

===

Subrayado 2

-—-

> Citas. 
>> Citas.

Listas sin enumeracion
* Elemento 1
- Elemento 2
+ Elemento 3

Listas con enumeracion:
1. Elemento 1
	- A
	- B
2. Elemento 2
	+ 1
	+ 2
3. Elemento 3

~~~
Bloque
~~~

Separadores

***
---
___

*Texto negrita*

_Texto negrita_

**Texto cursiva**

__Texto cursiva__

***Texto negrita y cursiva***

___Texto negrita y cursiva___

[Enlace](www.google.com)

`Codigo`

    Texto preformado con 4 espacios en blanco
	
![Imagen](ruta)

<www.google.com>

Tabla
|Columna 1|Columna 2|
|--------|--------|
|    A    |    B    |
|    C    |    D    |
