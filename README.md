# Practica_05_ChristianTorresGonzalez

Para la realizacion de esta quinta práctica, partire de la escena desarrollada para la pracica anterior, de tal forma que partiendo de las implementaciones y scripts anteiores, continuare con los puntos que se solicitan. Esos puntos que se solicitan son los siguientes:
1. Implementar una UI que permita configurar con qué poder jugarás: turbo y restas una vida o normal. 
2.  Agregar a tu escena un objeto que al ser recolectado por el jugador desplace del juego un tipo de objetos que puedan representar obstáculos, a modo de barreras que abren caminos.
3. Agrega un objeto que te teletransporte a otra zona de la escena.
4. Agrega un objeto físico que muevas con las teclas wasd.
5. Agrega un personaje que se dirija hacia un objetivo estático en la escena.
6. Agrega un personajes que se dirija al objeto del apartado 4.

Como consideración, hay que tener en cuenta, que la idea de esta practica es trabajar con los delegados y los eventos. Para ponernos un poco en contexto, debemos recordar que los delegados son aquellos controladores de escena, que comunicaran algún cambio en la escena, a todas aquellas funciones, que este controlando dicho delegado. Hasta ahora sabemos lo que es un delegado, pero no sabemos como comunica a los objetos, algún cambio en la escena esto lo hará mediante los eventos. Los eventos, son esos tipos de delegados, que cuando se activan, lanzan la ejecución de todas las funciones que tienen suscritas a ellos mismo. Una vez explicado esto, entrado mas en contexto, pasemos a explicar la realización de la practica.

Tal y como se aprecia en la imagen, lo primero que hago es definir mi delegado en la línea 7, de tal forma que si en otro script quiere trabajar con alguno de los eventos implementados, solo tengo que crear un objeto de dicha clase.
 

## Menu princpipal UI


## Coleccionables por la escena
Para esta segunda tarea lo que he hecho ha sido situar en la escena una serie de capsulas que cumplirán la tarea de ser unas llaves que al recolectarlas estas nos van desbloqueando ciertas partes del mapa. Además, he implementado dos tipos de llaves:
- Llave global: este tipo de llave, se identifica con una capsula roja en la escena, y permite abrir todas las puertas en el momento que la recogemos, es decir entramos en contacto con ella.
- Llave individual: esta tipo de llave, se identifica con una capsula verde, y permite abrir la puerta que tiene asociada, pero no el resto.

Como bien comente al principio, para poder lograr cumplir alguno de los objetivos de la practica, tendría que trabajar con delegados. Es aquí donde entran en juego, para ello, en primer lugar lo que haré será crear un delegado donde definiremos los diferentes eventos a desarrollar. Una vez definido el delegado, solo nos queda definir el evento al que se suscribirán las diferentes funciones que queremos que puedan lanzar alguno de los eventos definidos.

  ![Alt text](/img/delegado.png)
  
Desarrollada la clase encargada de gestionar e implementar los delegados, ya solo nos quedaría definir la llamada al evento del delegado. Para ello lo que hago es definir un script, en el cual compruebo que tipo de llave se ha recolectado para en función de eso eliminar una puerta u otra, para pasar el tipo de llave a la ejecución de llamada del evento del delegado.

![Alt text](/img/llave.png)

Una vez definido el script para recoger la llave, para finalizar con esta tarea, solo quedaría la implementación de la función que se tiene que ejecutar cuando el evento es lanzado. Es por eso que he creado un nuevo script, el cual se encargara de eliminar la puerta, una vez se lanza el evento. En dicho script, lo primero que hago es comprobar que tipo de llave se ha recogido, para así saber si tengo que eliminar una única puerta, o por el contrario eliminar todas las puertas.
- En caso de tener que eliminar todas las puertas, lo que hago es buscar en la escena todos los objetos con la etiqueta **"Puerta"** para eliminarlos. Además de esto, también hago una segunda búsqueda de todas las llaves que hay en la escena, ya que si recogemos la llave global, el resto de llaves sobrarían, por lo que son eliminadas.
- En caso contrario, es decir, en caso de que se haya recogido una llave concreta, lo que hago es definir una nueva función, que mediante una expresión regular se encarga de determinar a que puerta esta asociada la llave que ha sido recolectada. Una vez se que puerta tiene asociada dicha llave, solo queda eliminar la puerta y la llave

![Alt text](/img/puerta.png)


![Alt text](/img/puertas.gif)


## Teletransporte
El objetivo de esta segunda tarea trata de tener en la escena, algún objeto que te permita teletransportarte de un lado a otro.
Para esta tarea, lo que he hecho ha sido colocar un nuevo plano dentro de la escena, de tal forma que ahora existen dos zonas por la que poder moverse, una primera zona que es la misma que la de la practica pasada, y otra segunda zona que será la nueva donde estarán colocadas las llaves de la tarea anterior junto a las puertas que se irán abriendo. Para poder acceder a esta nueva zona lo que he hecho ha sido colocar en cada zona un objeto, en este caso una capsula que en el momento de tocarla, nos teletransportará a la otra zona. 

![Alt text](/img/teleport.png)

Tal y como se aprecia en la imagen, lo que hago es que en el momento en que algo entra en contacto con el teleport, compruebo que ha entrado en contacto, en caso de que sea el jugador, lo que hago es colocar al jugador en el punto de aparición de la zona contraria, punto el cual he definido como zona de aparición de cada escenario. Una vez he situado al jugador en las nuevas coordenadas, además también cambio la cámara a una nueva posición para que quede centrada en la nueva zona de juego. 
En caso de que vaya de la zona dos a la zona uno, seria exactamente lo mismo lo que cambiando el punto de spawn y la nueva posición de la cámara.

![Alt text](/img/teletransporte.gif)
