# Patrón Strategy - Comportamiento

## Descripción del Patrón

El patrón **Strategy (Estrategia)** permite definir una familia de algoritmos, encapsular cada uno y hacerlos intercambiables.  
El **Contexto** utiliza la estrategia seleccionada para ejecutar la operación sin depender de la implementación concreta.

## Implementación

En este proyecto, `Contexto` utiliza diferentes estrategias matemáticas (`Sumar`, `Restar`, `Multiplicar`) que implementan la interfaz `IOperacion`.  
Esto permite cambiar dinámicamente la operación sin modificar el contexto.

## Diagrama UML

```mermaid
classDiagram

class Contexto
Contexto : +IOperacion Estrategia
Contexto : +EjecutarOperacion(a, b) int

class IOperacion
IOperacion : +Operar(a, b) int

class Sumar
class Restar
class Multiplicar

IOperacion <|.. Sumar
IOperacion <|.. Restar
IOperacion <|.. Multiplicar
Contexto --> IOperacion : usa

note for Contexto "Contexto que utiliza la estrategia seleccionada"
note for Sumar "Estrategia concreta que suma dos números"
note for Restar "Estrategia concreta que resta dos números"
note for Multiplicar "Estrategia concreta que multiplica dos números"
