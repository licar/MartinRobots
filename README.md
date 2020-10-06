# MartinRobots
List of assumptions :
1) Solution shouldn't use any third part libraries, becouse it is not big and pull heavy libraries is not good idea
2) Solution should realize OO, that is why models should be Rich Domain Model
3) I can sacrifice flexibility in favor of an OO
4) Solution should consist of 3 layers and realize MVVM for weaker connectivity 
5) Solution should be easily covered by unit tests
7) For the fastest development it is enough to cover only the business layer with unit tests
8) Solution should have minimal interface for using - in this case it's console intefrace
9) OO model of application consist of 3 key classes Grid, Robots and Coordinators
  Robots - can move by command in specefic directions
  Grid - holds border information and "Scents"
  Coordinator - launches robots
10) Rotation - should happen by coordinates that is why directions must be able to mapping via coordinates. For quick mapping better to use dictionary
11) Movement - shuld use coordinates of directions
12) Required validate coordinates that is why better to do it at the input stage

Estimation : two working days 
