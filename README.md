📝 EXAMEN PROGRAMACIÓN P1
👥 Integrantes
Elian Hidalgo
Flavio Ibujés
Luis Morales
👨‍🏫 Tutor
Luis Aguas
🐉 DragonBallZ MVC - Sistema de Gestión
📌 Descripción
Este proyecto consiste en el desarrollo de una aplicación web utilizando el patrón MVC (Model - View - Controller) en ASP.NET, orientado a la gestión de entidades del universo Dragon Ball Z. Se implementa la interacción con base de datos mediante Entity Framework, permitiendo la manipulación de información de manera estructurada.
🎯 Objetivo
Implementar una aplicación funcional que permita la gestión de Guerreros y Técnicas, aplicando principios de programación orientada a objetos y persistencia de datos.
🛠️ Tecnologías utilizadas
ASP.NET MVC (.NET Framework)
Entity Framework (Code First)
SQL Server LocalDB
Razor Views
Bootstrap
📂 Estructura del proyecto
Models
Guerrero
Tecnica
DragonBallContext
Controllers
GuerrerosController
TecnicasController
HomeController
Views
CRUD completo para cada entidad
Vista principal con visualización de datos
⚙️ Funcionalidades principales
Registro de guerreros
Registro de técnicas
Visualización de datos en tablas
Edición de información
Eliminación de registros
Relación entre entidades (muchos a muchos)
Integración con base de datos mediante migraciones
🧩 Modelo de datos
Guerrero
Nombre
Raza
Nivel de poder
Transformación
Tecnica
Nombre de técnica
Tipo
Nivel de daño
Relación
Muchos a muchos entre Guerreros y Técnicas
