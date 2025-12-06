AppEmpresarial – Aplicación Multiplataforma en .NET MAUI

AppEmpresarial es una aplicación desarrollada en .NET MAUI diseñada como un sistema empresarial básico para la gestión de información interna.
Incluye módulos para:

- Gestión de productos
- Gestión de clientes
- Registro de ventas
- Control de stock
- Autenticación mediante base de datos SQLite

La aplicación está construida sin patrones avanzados como MVVM, utilizando únicamente archivos .xaml y .xaml.cs para mantener una arquitectura simple y orientada a ejercicios académicos.

---------------------------------------------------------------------

1. Pantalla de Login

La aplicación inicia con una pantalla de autenticación donde el usuario ingresa sus credenciales.
La validación se realiza contra una base de datos SQLite local.

Usuario por defecto creado automáticamente:

Usuario: admin
Contraseña: 1234

Si la validación es correcta, el usuario es dirigido a la pantalla principal.

---------------------------------------------------------------------

2. Pantalla Principal (MainPage)

La pantalla principal muestra un saludo personalizado y botones para navegar hacia los módulos disponibles:

- Productos
- Clientes
- Ventas
- Stock

La navegación se realiza mediante NavigationPage.

---------------------------------------------------------------------

3. Módulos de Gestión

Cada módulo utiliza un archivo XAML para la interfaz y un archivo .xaml.cs para la lógica.
Todos los módulos realizan operaciones CRUD básicas conectadas a SQLite.

3.1 Productos
- Agregar productos (nombre y precio)
- Mostrar lista de productos registrados
- Eliminar productos mediante gesto Swipe

3.2 Clientes
- Registrar nombre y correo electrónico
- Mostrar lista de clientes
- Eliminar clientes

3.3 Ventas
- Registrar producto vendido y total de la venta
- Mostrar lista de ventas
- Eliminar ventas registradas

3.4 Stock
- Registrar elementos del inventario
- Mostrar cantidades disponibles
- Eliminar elementos del stock

---------------------------------------------------------------------

4. Base de Datos SQLite

La aplicación utiliza la librería sqlite-net-pcl para gestionar almacenamiento local.
Las tablas creadas automáticamente incluyen:

- Usuarios
- Productos
- Clientes
- Ventas
- StockItem

El archivo de base de datos se genera en:

FileSystem.AppDataDirectory/appempresarial.db3

La base se inicializa al iniciar la aplicación.

---------------------------------------------------------------------

5. Layout y Estilos Utilizados

La aplicación utiliza un diseño sencillo basado en VerticalStackLayout en todas las pantallas.
Incluye estilos globales definidos en App.xaml y uso de CollectionView, Entry, Button y SwipeView para la interfaz.

---------------------------------------------------------------------

6. Arquitectura de Navegación

LoginPage
-> MainPage
    -> ProductosPage
    -> ClientesPage
    -> VentasPage
    -> StockPage

---------------------------------------------------------------------

7. Tecnologías utilizadas

- .NET MAUI
- C#
- XAML
- SQLite (sqlite-net-pcl)
- Navegación mediante NavigationPage
- Arquitectura sin MVVM

---------------------------------------------------------------------

8. Objetivo académico

Este proyecto fue creado con fines educativos para demostrar el uso de múltiples componentes de .NET MAUI y SQLite en una arquitectura sencilla.

---------------------------------------------------------------------

FIN DEL ARCHIVO
