# Xamarín
### ¿Qué es?
Es una herramienta que nos permite crear Apps nativas para iOS, Mac, Android, Windows Phone, Windows. Además nos permite utilizar solo un lenguaje de programación C# y el mismo código sea traducido para ejecutarse en las diferentes plataformas.
### Historia
En junio de 2000, Microsoft anunció por primera vez su .NET Framework. Miguel de Icaza, de Ximian, comenzó a investigar si una versión para Linux era factible. Posteriormente, el proyecto Mono fue lanzado el 19 de junio de 2001. Ximian fue adquirida por Novell el 4 de agosto de 2003.
Después de la subsiguiente adquisición de Novell por parte de Attachmate en abril de 2011, Attachmate anunció el despido de cientos de trabajadores de Novell, incluyendo a desarrolladores de Mono, poniendo así el futuro del proyecto en cuestión.
El 16 de mayo de 2011, Miguel de Icaza anunció en su blog que Mono será desarrollado y soportado por Xamarin, empresa que planea lanzar una serie de productos para dispositivos móviles. De acuerdo con de Icaza, al menos una parte del equipo original de Mono se ha movido a la nueva compañía.
Sin embargo, en julio de 2011, Novell, ahora una subsidiaria de Attachmate, anuncio que concedería una licencia perpetua a Xamarin para Mono, MonoTouch y Mono para Android, tomando así Xamarin la administración oficial del proyecto. En febrero de 2016 es comprada por Microsoft. 
### Funcionalidad
Con Xamarin podemos crear aplicaciones con una interfaz de usuario nativa. No solo cumpliendo los estándares, sino también el comportamiento que se espera de cada plataforma. Por otro lado también tenemos acceso a toda la API nativa de cada plataforma; con lo cual podemos acceder a todas las funcionalidades que expone el dispositivo. Todo esto aprovechando la aceleración de hardware de la plataforma específica para compilar las aplicaciones y tener un rendimiento nativo.
#### Dos Enfoques
##### Arquitectura clásica de Xamarín
![](https://marcrub.files.wordpress.com/2014/09/xamarin_old.png)
1. **Core Library:** Nos proporciona la posibilidad de crear código compartido en C# para reutilizar en todas las plataformas. De esta manera solo tendremos una librería donde poner nuestra lógica y reducir el código repetido y facilitar el mantenimiento.
2. **Specific Platform layer:** Aunque utilicemos código compartido siempre necesitaremos acceder a utilidades nativas de la plataforma y crear un interfaz de usuario específico para cada plataforma.
##### Xamarin.Forms
Es un framework que permite a los desarrolladores crear rápidamente interfaces de usuarios multiplataforma. Esto significa que las aplicaciones pueden compartir una gran parte de su código de interfaz de usuario. Aun así pueden conservar la apariencia nativa de la plataforma objetivo.
![](https://marcrub.files.wordpress.com/2014/09/xamarin_forms.png)
1. **Core Library:** Codigo compartido.
2. **Shared UI Code:** Interfaz de usuario compartido.
3. **Specific Platform layer:** Accesos a recursos específicos de cada plataforma.
### Instalacion
##### Windows
Xamarin se puede instalar como parte de una nueva instalación de Visual Studio 2017, con los siguientes pasos:
1. Descargue Visual Studio 2017 Community, Visual Studio Professional o Visual Studio Enterprise desde la página de Visual Studio
2. Haga doble clic en el paquete descargado para iniciar la instalación.
3. Seleccione el *Desarrollo para dispositivos moviles con .NET* en la pantalla de instalación:
![](https://hprez21.com/wp-content/uploads/2017/09/Screen-Shot-09-28-17-at-10.46-AM.png)
4. Mientras se selecciona *Desarrollo para dispositivos moviles con .NET* , eche un vistazo al panel de detalles de la instalación a la derecha. Aquí, puede deseleccionar las opciones de desarrollo móvil que no desea instalar:
![](https://docs.microsoft.com/en-us/xamarin/cross-platform/get-started/installation/windows-images/02-summary.png)
5. Cuando esté listo para comenzar la instalación de Visual Studio 2017, haga clic en el botón Instalar en la esquina inferior derecha:
![](https://docs.microsoft.com/en-us/xamarin/cross-platform/get-started/installation/windows-images/03-click-install.png)
6. Cuando se haya completado la instalación de Visual Studio 2017, haga clic en el botón Iniciar para iniciar Visual Studio:
![](https://docs.microsoft.com/en-us/xamarin/cross-platform/get-started/installation/windows-images/05-launch.png)

##### Mac
1. Descargue Visual Studio para Mac desde https://visualstudio.microsoft.com/
2. Una vez que se descarga el paquete del instalador, haga clic en el archivo VisualStudioInstaller.dmg para montar el instalador y luego ejecútelo haciendo doble clic en el logotipo, como se ilustra en la siguiente imagen:
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image1.png)
3. Es posible que aparezca un cuadro de diálogo de alerta similar al de la siguiente imagen. En este caso, haga clic en Abrir :
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image2.png)
4. El instalador inspecciona su sistema para verificar qué componentes deben instalarse o actualizarse:
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image3.png)
5. A continuación, aparecerá un cuadro de diálogo de alerta que le solicitará que reconozca los Términos de privacidad y licencia. Presione el botón Continuar para reconocer los términos:
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image4.png)
6. El instalador presenta una lista de los componentes necesarios que faltan y que deben descargarse e instalarse. Seleccione los productos que desea descargar aquí:
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image5.png)
7. Una vez que esté satisfecho con su selección, seleccione el botón Instalar y actualizar para iniciar el proceso de instalación.
8. El instalador inicia el proceso de descarga e instalación de los elementos seleccionados:
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image7.png)
9. Es posible que se le solicite que aumente los permisos necesarios para los componentes individuales que se necesitan para completar la instalación. Ingrese sus credenciales de administrador aquí para continuar el proceso de instalación:
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image10.png)
10. Una vez que la instalación se haya realizado correctamente, puede comenzar a desarrollar aplicaciones en Visual Studio presionando Iniciar :
![](https://docs.microsoft.com/en-us/visualstudio/mac/media/installer-image11.png)

### Crear un proyecto
1. Vamos a *Archivo* , *Nuevo* , *Proyecto*
2. Nos aseguramos que diga *Visual c#* , *Android* , *Aplicacion de Android(Xamarin)*
3. Seleccionamos *Aplicacion Vacia* y apretamos *OK*