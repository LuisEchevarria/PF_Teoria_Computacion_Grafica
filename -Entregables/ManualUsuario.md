# Five Nights at Freddy's - Simulador Guardia de Seguridad 3D

Este repositorio contiene el proyecto interactivo de simulación basado en el universo de *Five Nights at Freddy's*, desarrollado en **Unity Engine**. Está implementado con gráficos en tiempo real, iluminación dinámica y un sistema de control de cámaras y accesos desde la perspectiva de la cabina de seguridad.

---

## Instrucciones de Instalación

El software se distribuye en dos formatos independientes para facilitar su ejecución en sistemas Windows. Elija el método que mejor se adapte a sus necesidades de uso.

### Opción 1: Instalación mediante Ejecutable Directo (`.exe`)
Este método es el más recomendado para una experiencia de usuario directa, asumiendo que el proyecto fue empaquetado en un solo instalador o archivo autoextraíble.

1. **Descarga:** Descargue el archivo `FNAF_Simulador.exe` desde la sección de lanzamientos (*Releases*) o el enlace de descarga provisto.
2. **Ejecución:** Haga doble clic sobre el archivo ejecutable. 
3. **Permisos de Seguridad:** En caso de que el sistema operativo Windows muestre una advertencia de protección (*SmartScreen*), haga clic en **"Más información"** y posteriormente seleccione **"Ejecutar de todos modos"**.
4. **Inicialización:** El programa configurará automáticamente el entorno de Unity y los recursos gráficos en la memoria temporal del sistema para iniciar la simulación de forma inmediata.

### Opción 2: Descarga e Inicialización mediante Archivo Comprimido (`.zip`)
Este método es el estándar para compilaciones (*builds*) nativas de Unity, ideal para ejecutar el programa de forma portable sin realizar modificaciones en el registro del sistema.

1. **Descarga:** Descargue el paquete comprimido titulado `FNAF_Simulador_Portatil.zip`.
2. **Extracción de Recursos:** * Haga clic derecho sobre el archivo `.zip` descargado.
   * Seleccione la opción **"Extraer todo..."**.
   * Elija una ruta de destino local (por ejemplo, el Escritorio o la carpeta de Documentos) y confirme la acción.
   * *Nota Crítica:* Es indispensable mantener el archivo `.exe` junto a la carpeta `_Data` y los archivos `.dll` (como `UnityPlayer.dll`) en el mismo directorio raíz. Si estos componentes se separan, el motor de Unity no podrá cargar los recursos gráficos, texturas ni modelos.
3. **Lanzamiento:** Ingrese a la carpeta extraída y ejecute mediante doble clic el archivo principal `FNAF_Simulador.exe`.

---

## Manual de Operación y Funcionalidades del Software

El programa sitúa al operador en la cabina del Guardia de Seguridad. Desde esta posición, se controlan los sistemas perimetrales y de monitoreo ambiental mediante interacciones del teclado y el mouse.

### 1. Sistema de Monitoreo por Circuito Cerrado (Cámaras de Seguridad)
La instalación cuenta con cinco cámaras analíticas distribuidas de manera estratégica. La transición visual entre los diferentes canales se gestiona completamente a través del hardware del puntero.

* **Control de Navegación:** El cambio de toma se efectúa presionando el **Clic Derecho del Mouse**. Cada pulsación cicla de manera secuencial a través de las cinco vistas disponibles.

#### Guía de Canales del Circuito Cerrado:
* **Cámara 1 (Escenario de Animatrónicos):** Enfoque principal de la tarima central del establecimiento, diseñado para supervisar la presencia y el estado estático de la banda de animatrónicos.
* **Cámara 2 (Escenario de Foxy / Pirate Cove):** Cobertura específica orientada a la zona secundaria de cortinas, permitiendo validar la actividad o resguardo de Foxy.
* **Cámara 3 (Esquina Derecha / Puppet y Comedor):** Toma angular que visualiza la intersección del pasillo lateral derecho, enfocando la caja musical de Puppet y las mesas contiguas.
* **Cámara 4 (Comedor General):** Perspectiva amplia del área de mesas de banquete, decoraciones con globos y la vista frontal-baja hacia el escenario central.
* **Cámara 5 (Vista Exterior / Sistema Skybox):** Conexión técnica hacia la cámara periférica externa del recinto. Esta toma implementa un *Skybox* tridimensional que renderiza la atmósfera exterior de la pizzería.

### 2. Control de Iluminación Dinámica e Interactiva
El motor de renderizado integra un sistema de luces en tiempo real. Cada circuito lumínico actúa como un interruptor de palanca (*toggle*), donde la misma tecla enciende y apaga el circuito correspondiente.

* **Tecla [ P ] — Lámparas del Cuarto de Seguridad:** Activa o desactiva las luminarias locales dentro de la oficina del guardia, proporcionando visibilidad inmediata sobre los accesos directos.
* **Tecla [ O ] — Lámparas del Comedor:** Controla el sistema de iluminación general del salón de mesas, permitiendo aclarar u oscurecer la escena principal visible en las cámaras de monitoreo.
* **Tecla [ N ] — Modulador Ambiental del Skybox (Ciclo Día/Noche):** Interviene directamente sobre la luz direccional global (*Directional Light*) de la escena. Alterna el entorno entre condiciones de iluminación diurna y nocturna, modificando la proyección de sombras y el material del cielo (*skybox*) visible desde la Cámara 5.

### 3. Mecanismo Automatizado de Puertas de Seguridad
La oficina del guardia cuenta con compuertas blindadas de respuesta inmediata a ambos costados para contener amenazas externas. Las animaciones calculan la traslación de los paneles rígidos en tiempo real.

* **Tecla [ Q ] — Puerta Lateral Izquierda:** Al presionarla, se dispara la animación de sellado o cierre de la compuerta izquierda. Al pulsarla nuevamente, se revierte la animación, abriendo el acceso y desactivando el bloqueo.
* **Tecla [ E ] — Puerta Lateral Derecha:** Al presionarla, se ejecuta la animación de descenso y cierre de la compuerta derecha. Una segunda pulsación retrae el panel hacia su posición abierta inicial.

---

## Especificaciones Técnicas Básicas
* **Motor Gráfico:** Desarrollado y compilado en Unity Engine 6.3 LTS.
* **Plataforma:** Windows 10 / Windows 11 (Arquitectura de 64 bits).
* **Entorno de Entrada:** Ratón con botón secundario habilitado y Teclado estándar QWERTY.
* **Aceleración Gráfica:** Tarjeta gráfica compatible con DirectX 10/11/12, Vulkan o equivalente (Requisitos estándar de Unity).
