# API Development with Entity Framework and Code First Approach

<p align="center">
  <img src="https://github.com/floresernesto95/Images/blob/main/code_first_repo%201.webp.png"/>
</p>

## Descripción General

Este proyecto muestra una sofisticada API de Tareas Pendientes desarrollada en C# y Entity Framework con un enfoque Code First. Diseñado para demostrar mi experiencia en prácticas modernas de desarrollo de software, este proyecto es un ejemplo integral de cómo construir una API RESTful robusta, escalable y eficiente.

## Características Clave

- **Entity Framework Code First**: Utiliza la metodología Code First de EF Core, permitiendo un esquema de base de datos limpio y mantenible, fácilmente gestionado a través de clases y migraciones en C#.
- **API RESTful**: Implementa operaciones CRUD para gestionar tareas pendientes y categorías, adheriéndose a los principios REST para interacciones cliente-servidor fluidas y predecibles.
- **Inyección de Dependencias**: Demuestra el uso de inyección de dependencias para promover un acoplamiento débil y mejorar la capacidad de prueba.
- **Objetos de Transferencia de Datos (DTOs)**: Maneja eficientemente la transformación de datos entre modelos de dominio y clientes de API, asegurando seguridad y rendimiento.
- **Inicialización de Datos**: Incluye la inicialización de datos para categorías, proporcionando una base de datos lista para usar al iniciar la aplicación.
- **Manejo de Errores**: Manejo de errores integral para asegurar la fiabilidad y proporcionar retroalimentación significativa a los clientes.

## Aspectos Técnicos Destacados

### Integración con Entity Framework Core

Aprovechando el poder de EF Core, este proyecto incluye un DbContext bien estructurado (`ToDoContext`) que gestiona las operaciones de base de datos para las entidades `ToDoItem` y `Categoria`. El enfoque Code First asegura que el esquema de la base de datos evolucione sin problemas junto con el código de la aplicación.

### Endpoints de la API

- **GET /api/todoitems**: Obtiene todas las tareas pendientes, incluyendo los datos de las categorías relacionadas, mostrando el uso eficiente del método `Include` de Entity Framework para carga ansiosa.
- **POST /api/todoitems**: Permite la creación de nuevas tareas pendientes, demostrando una validación robusta de modelos y técnicas de persistencia de datos.
- **PUT /api/todoitems**: Actualiza las tareas pendientes existentes, destacando el uso práctico del método `Update` y el manejo de la concurrencia.
- **DELETE /api/todoitems/{id}**: Elimina tareas pendientes, asegurando la integridad de los datos y el manejo adecuado de registros inexistentes.

### Calidad del Código

- **Arquitectura Modular**: Se adhiere a los principios SOLID, promoviendo un código base limpio, mantenible y extensible.
- **Documentación**: Código bien comentado con documentación XML para métodos y clases públicos.
- **Pruebas Automatizadas**: Listo para la integración con pruebas unitarias y de integración, asegurando alta fiabilidad del código y reduciendo problemas de regresión.

## Tecnologías Utilizadas

- **Lenguaje**: C#
- **Framework**: .NET Core
- **ORM**: Entity Framework Core
- **Base de Datos**: SQL Server
- **Herramientas**: Visual Studio, Postman (para pruebas de API)

## Conclusión

Este proyecto es un testimonio de mi capacidad para diseñar e implementar aplicaciones complejas y de alto rendimiento utilizando las últimas tecnologías en el ecosistema .NET. Al emplear las mejores prácticas en desarrollo de API y gestión de bases de datos, he creado una API de Tareas Pendientes confiable y eficiente que puede servir como una base sólida para un mayor desarrollo y mejora.
