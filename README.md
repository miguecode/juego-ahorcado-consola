# 🕹️ Juego Ahorcado - Aplicación de Consola en C#

Este proyecto es una aplicación de consola, fue hecho en 2022 y trata de simular el juego del Ahorcado. El usuario puede jugar cuantas veces quiera, y hasta tiene la opción de agregar o borrar palabras del sistema. Creado en .NET con C#.

## 📘 Reglas del Juego

- El ahorcado (también llamado colgado) es un juego de adivinanzas de lápiz y papel para dos o más jugadores. Un jugador piensa en una palabra, frase u oración y el otro trata de adivinarla según lo que sugiere por letras o dentro de un cierto número de oportunidades.
- En este caso, el sistema elige automáticamente una palabra de forma aleatoria entre las que tiene cargadas, para que el jugador trate de adivinarla. 
- Usando una fila de guiones, se representa la palabra a adivinar. Si el jugador adivinador sugiere una letra que aparece en la palabra, el sistema la ubicará en todas sus posiciones correctas.
- Si la letra no se encuentra en la palabra, el jugador pierde una vida y se dibujará de a poco la silueta de la persona esperando por ser ahorcada...
- El jugador tiene 5 vidas. Al quedarse sin vidas, se completará el dibujo del ahorcado y el jugador pierde el juego. Si adivina la palabra antes de perder sus vidas, gana la partida.

## 👨‍💻 Menú Principal 

Así se ve la pantalla principal al iniciar el programa.

<img src="https://github.com/user-attachments/assets/5449cce0-6683-4127-afdd-7a7691de1010" width="450"/>

## 😁 Escenario de victoria

Así se ve cuando ganas la partida.

<img src="https://github.com/user-attachments/assets/f5c55de9-efc8-4f97-9959-53b6a7405e6f" width="450"/>

## ☠️ Escenario de derrota

Así se ve cuando perdes la partida.

<img src="https://github.com/user-attachments/assets/52326442-1de8-4e00-a2ce-5e3025f21c9a" width="450"/>

## 🛠️ Funcionalidades

- **Iniciar la partida**: Da a inicio a un nuevo juego desde 0, con una palabra seleccionada al azar.
- **Mostrar Palabras**: Muestra todas las palabras cargadas actualmente en el sistema. Por defecto, el juego viene con 9 palabras posibles.
- **Agregar o Eliminar Palabras**: Permite agregar nuevas palabras, o eliminar las que ya existen en el sistema.

## 🚀 Cómo Ejecutar el Proyecto

### Para Programadores usando Visual Studio (Recomendado)

1. **Clonar el repositorio**: Primero que nada hay que clonar el repositorio o en su defecto descargar el ZIP.
   
2. **Abrir el proyecto en Visual Studio**: Abrir Visual Studio y seleccionar "Abrir un proyecto o solución". Después, ir hasta la carpeta del proyecto y elegir el archivo `AhorcadoNetCore.sln`. O más rápido, simplemente hacer doble clic en `AhorcadoNetCore.sln`.

3. **Compilar y ejecutar**: Con el proyecto cargado, ya se puede compilar y ejecutar normalmente. Esto abrirá la aplicación de consola.

### Para Programadores usando Visual Studio Code

1. **Instalar .NET SDK**: Antes que nada, hay que tener instalado [SDK de .NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0) en tu máquina.

2. **Clonar el repositorio**: Después, clonar el repositorio o en su defecto descargar el ZIP.

3. **Abrir el proyecto en Visual Studio Code**: Abrir Visual Studio Code y abrir la carpeta del proyecto.

4. **Compilar y ejecutar**: Ya en el VSC, abrir la terminal integrada (`Ctrl + ñ`) y navegar hasta la carpeta del proyecto. Por último, usar el comando `dotnet run` para compilar y ejecutar la aplicación.

### Para Usuarios comunes

1. **Descargar el archivo ZIP**: Ir a la sección de "Releases" en GitHub y descargar el archivo `.zip` que contiene el archivo ejecutable.

2. **Extraer el archivo**: Descomprimir el archivo `.zip` en una carpeta cualquiera de tu escritorio.

3. **Ejecutar el archivo .exe**: Ir hasta la carpeta `AhorcadoNetCore/bin/Debug/net6.0/` y hacer doble clic al archivo `AhorcadoNetCore.exe` para iniciar la aplicación.

## 📌 Aclaraciones
- Fue creado en 2022, mientras cursaba la carrera de Tecnicatura Universitaria en Programación, en la Universidad Tecnológica Nacional.
- No se aceptan contribuciones ni está bajo ninguna licencia específica.
