#Procedural2

PenguinSumo
===========

Explicación
-----------
Un shooter en primeira persona con un mapa autoxerado, onde respawns fan aparecer pinguinos que intentarán tirarte fora do mapa.

Idea principal: 
Generación automática de niveles
--------------------------------
https://www.youtube.com/watch?v=v7yyZZjF1z4&list=PLFt_AvWsXl0eZgMK_DT5_biRkWXftAOf9
Usei este porque a xeración é aleatoria a partir de un número que podría ser dado polo nivel que queres xogar e por un índice de terreo que pode ligarse a dificultade, canto máis porcentaxe maior dificultade o ter menos espacio para ecapar.
Básicamente a través de o número e a porcentaxe prodúcese un mapa dividido en varias zonas que cumplirán varias condicións: Ter un tamaño mínimo xogable, que nunca queden aisladas ningunha das zonas e ter unha forma "natural".

Ideas secundarias:
Mecánicas de Shooter
--------------------
https://www.youtube.com/watch?v=5fLAFV_m88Y
Usei este porque só se lle da vida aos enemigos xa que o player debe morrer ao caer do mapa.

Respawns de enemigos
--------------------
https://www.youtube.com/watch?v=GHW9bpX7n_Q&t=25s

Intelixencia artificial dos enemigos
------------------------------------
https://www.youtube.com/watch?v=G60le64vmM4&t=70s
Utilicei este porque case todos utilizan a ferramente de navigation cousa que para un mapa que se xenera ao darlle ao play, non funciona

Morte por caida
---------------
https://www.youtube.com/watch?v=KJlvgCIkcnU&t=470s
Toda morte por caida a preparaban para que canto máis cairas, máis daño pero o que quería era a morte total entón pensei en por paredes invisibles que sacaran a mensaxe por pantalla de morte.


Ideas a implementar
----------------

-Un menú que meta o número de nivel na SEED e dificultad 
-Pulir animacións
-Un sistema de recompensa con puntos ou tempo vivo

