# LeonComputing_capas
# Proyecto: Mantenimiento de Aplicación de Escritorio con SQL Server

Este proyecto consiste en el desarrollo de una **aplicación de escritorio** orientada al mantenimiento de datos. Utiliza una **arquitectura en capas** para separar las responsabilidades de presentación, negocio y acceso a datos. La aplicación interactúa con **SQL Server** mediante **Data.SqlClient**, una librería de ADO.NET que facilita la comunicación con la base de datos para realizar operaciones CRUD de manera eficiente.

## Características y Tecnologías utilizadas:

- **Arquitectura en Capas**: Implementación de una estructura de capas que divide la lógica en tres niveles:
  - **Capa de Presentación**: Maneja la interfaz de usuario, gestionando la interacción con el usuario.
  - **Capa de Negocio**: Contiene la lógica de negocio, gestionando la validación y las reglas del sistema.
  - **Capa de Datos**: Gestiona el acceso a la base de datos y las operaciones CRUD.

  Esto asegura una mejor organización del código y facilita el mantenimiento y escalabilidad de la aplicación.

- **Acceso a Datos con Data.SqlClient**: Uso de **Data.SqlClient** para la conexión y ejecución de consultas en **SQL Server**, optimizando el flujo de datos entre la aplicación y la base de datos.

- **Operaciones CRUD**: La aplicación permite realizar las operaciones **Crear**, **Leer**, **Actualizar** y **Eliminar** datos de forma sencilla, con validación y manejo de errores en cada operación.

- **Interfaz de Usuario de Escritorio**: Desarrollo de una interfaz sencilla y accesible para el usuario, utilizando herramientas de desarrollo de aplicaciones de escritorio como **Windows Forms**.

