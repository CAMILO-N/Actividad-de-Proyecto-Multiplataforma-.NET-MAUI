<h1 align="center">AppEmpresarial – Aplicación Multiplataforma en .NET MAUI</h1>

<p align="center">
  Sistema empresarial básico desarrollado en .NET MAUI, con módulos de gestión, autenticación con SQLite
  y navegación mediante NavigationPage.
</p>

<hr>

<h2>Descripción General</h2>

<p>
AppEmpresarial es una aplicación creada con .NET MAUI siguiendo una arquitectura sencilla basada en archivos
<code>.xaml</code> y <code>.xaml.cs</code> sin utilizar MVVM. El objetivo del proyecto es comprender cómo construir interfaces,
manejar navegación y trabajar con SQLite en aplicaciones multiplataforma.
</p>

<hr>

<h2>Características Principales</h2>

<ul>
  <li>Pantalla de Login con validación en SQLite</li>
  <li>Pantalla principal con navegación hacia los módulos</li>
  <li>Módulos CRUD completos:
    <ul>
      <li>Productos</li>
      <li>Clientes</li>
      <li>Ventas</li>
      <li>Stock</li>
    </ul>
  </li>
  <li>Base de datos local con sqlite-net-pcl</li>
  <li>Interfaz construida solo con XAML + Code-behind</li>
</ul>

<hr>

<h2>Pantalla de Login</h2>

<p>La app inicia solicitando usuario y contraseña. Las credenciales se validan contra SQLite.</p>

<p><strong>Usuario por defecto:</strong></p>

<pre>
Usuario: admin
Contraseña: 1234
</pre>

<p>Si las credenciales son correctas, el usuario navega a la pantalla principal.</p>

<hr>

<h2>Pantalla Principal</h2>

<p>Incluye botones que permiten acceder a los módulos:</p>

<ul>
  <li>Gestión de Productos</li>
  <li>Gestión de Clientes</li>
  <li>Registro de Ventas</li>
  <li>Gestión de Stock</li>
</ul>

<p>La navegación se realiza mediante:</p>

<pre><code>Navigation.PushAsync(new ProductosPage());</code></pre>

<hr>

<h2>Módulos de Gestión</h2>

<p>Cada módulo cuenta con su propio XAML y archivo .cs con operaciones CRUD conectadas a SQLite.</p>

<h3>Productos</h3>
<ul>
  <li>Agregar productos (nombre y precio)</li>
  <li>Listar productos</li>
  <li>Eliminar productos mediante SwipeView</li>
</ul>

<h3>Clientes</h3>
<ul>
  <li>Agregar clientes (nombre y correo)</li>
  <li>Listar clientes</li>
  <li>Eliminar registros</li>
</ul>

<h3>Ventas</h3>
<ul>
  <li>Registrar ventas</li>
  <li>Listarlas</li>
  <li>Eliminar ventas</li>
</ul>

<h3>Stock</h3>
<ul>
  <li>Controlar inventario</li>
  <li>Registrar artículos y cantidades</li>
  <li>Eliminar registros</li>
</ul>

<hr>

<h2>Base de Datos SQLite</h2>

<p>La app utiliza <code>sqlite-net-pcl</code> para el manejo de almacenamiento local.</p>

<p>Tablas generadas automáticamente:</p>

<ul>
  <li>Usuarios</li>
  <li>Productos</li>
  <li>Clientes</li>
  <li>Ventas</li>
  <li>StockItem</li>
</ul>

<p>Ruta del archivo SQLite:</p>

<pre><code>FileSystem.AppDataDirectory/appempresarial.db3</code></pre>

<hr>

<h2>Layout y Estilos Utilizados</h2>

<p>El diseño se basa en <code>VerticalStackLayout</code> con un estilo global para botones definido en <code>App.xaml</code>.</p>

<pre><code>&lt;Color x:Key="PrimaryColor"&gt;#2563EB&lt;/Color&gt;

&lt;Style TargetType="Button"&gt;
    &lt;Setter Property="BackgroundColor" Value="{StaticResource PrimaryColor}" /&gt;
    &lt;Setter Property="TextColor" Value="White" /&gt;
    &lt;Setter Property="CornerRadius" Value="8" /&gt;
    &lt;Setter Property="Padding" Value="10" /&gt;
&lt;/Style&gt;
</code></pre>

<p>Se emplean los siguientes controles:</p>

<ul>
  <li>Entry</li>
  <li>Button</li>
  <li>CollectionView</li>
  <li>SwipeView</li>
</ul>

<hr>

<h2>Arquitectura de Navegación</h2>

<pre>
LoginPage
  → MainPage
      → ProductosPage
      → ClientesPage
      → VentasPage
      → StockPage
</pre>

<hr>

<h2>Tecnologías Utilizadas</h2>

<ul>
  <li>.NET MAUI</li>
  <li>C#</li>
  <li>XAML</li>
  <li>SQLite (sqlite-net-pcl)</li>
  <li>NavigationPage</li>
  <li>Code-behind sin MVVM</li>
</ul>

<hr>

<h2>Objetivo Académico</h2>

<p>
Este proyecto se desarrolló con fines educativos para practicar:
</p>

<ul>
  <li>Navegación en MAUI</li>
  <li>Manejo de SQLite</li>
  <li>Construcción de interfaces con XAML</li>
  <li>Operaciones CRUD básicas</li>
  <li>Estructuración simple sin patrones avanzados</li>
</ul>

<hr>

<h2>Créditos</h2>

<p>Proyecto desarrollado como parte de la asignatura de Desarrollo Multiplataforma con .NET MAUI.</p>
