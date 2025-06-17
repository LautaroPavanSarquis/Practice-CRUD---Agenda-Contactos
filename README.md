# Agenda de Contactos - CRUD en ASP.NET Core 8

Este proyecto es una agenda de contactos simple desarrollada con **ASP.NET Core 8**, con el objetivo de practicar y afianzar conceptos clave del desarrollo web en .NET.

## 🎯 Objetivos del proyecto

- Practicar el desarrollo de aplicaciones web con **ASP.NET Core 8**.
- Familiarizarse con la sintaxis de **Razor Pages** y explorar brevemente **Blazor**.
- Implementar un CRUD completo: **Crear, Leer, Editar y Eliminar contactos**.
- Aplicar **buenas prácticas de desarrollo seguro**, como la validación del modelo y protección contra **inyecciones SQL**.
- Consolidar conocimientos sobre el patrón **MVC** y el uso de **Entity Framework Core**.
- Ganar experiencia práctica en el uso de **Git**, ramas y control de versiones desde consola.

## ⚙️ Funcionalidades

- Listado de contactos
- Creación de nuevos contactos
- Edición de contactos existentes
- Visualización de detalles
- Eliminación con confirmación
- Validación del lado del servidor y del cliente

## 🛡️ Seguridad

- Se utilizó `ModelState.IsValid` y validaciones por atributos para proteger contra datos maliciosos.
- El uso de **Entity Framework Core** permite prevenir ataques de **inyección SQL** al evitar consultas manuales.

## 🧪 Tecnologías utilizadas

- ASP.NET Core 8
- Razor Pages
- Entity Framework Core
- SQL Server
- Bootstrap 5
- Visual Studio 2022

## 🗄️ Base de datos

El proyecto utiliza su **propia base de datos en SQL Server**, generada automáticamente mediante **migraciones de EF Core**.

