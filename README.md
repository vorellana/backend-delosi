# Backend -  Rotar matriz en sentido horario

![image](https://github.com/vorellana/backend-delosi/assets/3950493/c6c153bb-b22a-4e95-bc07-e34a6bfa6636)
![image](https://github.com/vorellana/backend-delosi/assets/3950493/85431217-aebe-40ab-a481-9605670b374d)

## Explicación del dominio: Matriz al ser una estructura de datos entonces se toman sus similares como colas, pilas, arreglos y grafos para poder crear los demás endpoints y cada uno en su propio controlador y con sus respectivas operaciones, donde se asume por el momento que todas las operaciones son POST.

### Características
* **Se implementaron todos los puntos requeridos**
* Aplicación de buenas prácticas de diseño de APIS
* Pruebas unitarias
* Manejo de errores
* Validación de entrada (que el Json de entrda sea válido)
* Configuración del Content-Type por solicitud y respuesta
* Dockerizado
* Documentación en Swagger (se generó automáticamente)
* Creación de demás endPoints

### Consideraciones para despliegue con Docker
**El proyecto se encuentra configurado para ejecutarse siempre en el puerto 5024**

Pasos para el despliegue
```sh
# navegamos por la terminal hasta donde esté el archivo Dockerfile
# creamos la imagen con el comando:
docker build -t imagen-matriz .

# iniciamos el contenedor
docker run -d -p 5024:5024 --name app-matriz imagen-matriz
```

### Ahora la aplicación se encuentra disponible en localhost:5024 y podemos utilizarla con Postman, como se detalla en la imagen de arriba.


# Gracias!
