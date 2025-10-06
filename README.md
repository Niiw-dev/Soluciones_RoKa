# 🏗️ Soluciones RoKa — Sitio Web Interactivo con Blazor Server & SignalR

> 💬 *Proyecto personal desarrollado con el propósito de practicar y comprender a fondo Blazor Server, explorando la comunicación en tiempo real mediante SignalR.*

---

### 🧠 Descripción
**Soluciones RoKa** es una página web informativa desarrollada con **Blazor Server** y **SignalR**, creada para explorar la integración en tiempo real entre cliente y servidor.  
El sitio presenta los **servicios de una empresa**, junto con una **sección de contacto** que permite enviar mensajes desde un formulario, con **notificaciones instantáneas** al administrador.  

Este proyecto fue un ejercicio práctico para afianzar conocimientos en **componentización, diseño de interfaces interactivas** y **comunicación en tiempo real** dentro del ecosistema .NET.

---

### 🧩 Características principales
- 🧭 **Página informativa** con secciones de servicios y contacto.  
- ⚡ **SignalR** para el envío y recepción de mensajes en tiempo real.  
- 🧱 **Arquitectura modular Blazor Server** con componentes reutilizables.  
- 🖌️ **Diseño responsive** implementado con Bootstrap.  
- 🔔 **Notificaciones instantáneas** cuando un usuario envía un formulario.

---

### 🛠️ Tecnologías Utilizadas
- **Framework:** Blazor Server (.NET 8)  
- **Comunicación en tiempo real:** SignalR  
- **Lenguaje:** C#  
- **Frontend:** HTML5, CSS3, Bootstrap  
- **Control de versiones:** Git

---

### ⚙️ Instalación
1. Clona el repositorio:
   ```bash
   git clone https://github.com/Niiw-dev/Soluciones_RoKa.git
   ```
2. Restaura las dependencias del proyecto:
   ```bash
   dotnet restore
   ```
3. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```
4. Accede a la aplicación en tu navegador en: `https://localhost:5001`

---

### 🚀 Uso
Al acceder al sitio, el usuario puede:
- Navegar por las secciones de información y servicios.
- Completar y enviar el formulario de contacto.
- Ver cómo el sistema notifica automáticamente la recepción del mensaje en tiempo real.

---

### 🧩 Estructura del Proyecto
```plaintext
📦 Soluciones_RoKa
 ┣ 📂 Data/                 # Servicios de datos e inyección de dependencias
 ┣ 📂 Hubs/                 # Hubs SignalR para comunicación en tiempo real
 ┣ 📂 Pages/                # Componentes principales de Blazor (razor pages)
 ┣ 📂 Shared/               # Componentes compartidos entre páginas
 ┣ 📂 wwwroot/              # Archivos estáticos (CSS, JS, imágenes)
 ┣ 📜 App.razor             # Archivo raíz de la aplicación Blazor
 ┣ 📜 Program.cs            # Configuración de servicios y aplicación
 ┣ 📜 _Imports.razor        # Importaciones globales de namespaces
 ┗ 📜 README.md             # Documentación del proyecto
```

---

### 👨‍💻 Autor
Creado por **[Niiw.Dev](https://github.com/Niiw-dev)** 🔥
