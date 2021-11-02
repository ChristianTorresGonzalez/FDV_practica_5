# Practica_05_ChristianTorresGonzalez

Para la realizacion de esta quinta práctica, partire de la escena desarrollada para la pracica anterior, de tal forma que partiendo de las implementaciones y scripts anteiores, continuare con los puntos que se solicitan. Esos puntos que se solicitan son los siguientes:
1. Implementar una UI que permita configurar con qué poder jugarás: turbo y restas una vida o normal. 
2.  Agregar a tu escena un objeto que al ser recolectado por el jugador desplace del juego un tipo de objetos que puedan representar obstáculos, a modo de barreras que abren caminos.
3. Agrega un objeto que te teletransporte a otra zona de la escena.
4. Agrega un objeto físico que muevas con las teclas wasd.
5. Agrega un personaje que se dirija hacia un objetivo estático en la escena.
6. Agrega un personajes que se dirija al objeto del apartado 4.

Como consideración, hay que tener en cuenta, que la idea de esta practica es trabajar con los delegados y los eventos. Para ponernos un poco en contexto, debemos recordar que los delegados son aquellos controladores de escena, que comunicaran algún cambio en la escena, a todas aquellas funciones, que este controlando dicho delegado. Hasta ahora sabemos lo que es un delegado, pero no sabemos como comunica a los objetos, algún cambio en la escena esto lo hará mediante los eventos. Los eventos, son esos tipos de delegados, que cuando se activan, lanzan la ejecución de todas las funciones que tienen suscritas a ellos mismo. Una vez explicado esto, entrado mas en contexto, pasemos a explicar la realización de la practica.

![Alt text](/img/escena.png)

Tal y como se aprecia en la imagen, lo primero que hago es definir mi delegado en la línea 7, de tal forma que si en otro script quiere trabajar con alguno de los eventos implementados, solo tengo que crear un objeto de dicha clase.
 

### Menu princpipal UI


### Coleccionables por la escena
Para esta segunda tarea lo que he hecho ha sido situar en la escena una serie de capsulas que cumplirán la tarea de ser unas llaves que al recolectarlas estas nos van desbloqueando ciertas partes del mapa. Además, he implementado dos tipos de llaves:
- Llave global: este tipo de llave, se identifica con una capsula roja en la escena, y permite abrir todas las puertas en el momento que la recogemos, es decir entramos en contacto con ella.
- Llave individual: esta tipo de llave, se identifica con una capsula verde, y permite abrir la puerta que tiene asociada, pero no el resto.

Como bien comente al principio, para poder lograr cumplir alguno de los objetivos de la practica, tendría que trabajar con delegados. Es aquí donde entran en juego, para ello, en primer lugar lo que haré será crear un delegado donde definiremos los diferentes eventos a desarrollar. Una vez definido el delegado, solo nos queda definir el evento al que se suscribirán las diferentes funciones que queremos que puedan lanzar alguno de los eventos definidos.

  ![Alt text](/img/escena.png)
