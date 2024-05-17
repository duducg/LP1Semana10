```mermaid
---
title : PlayerManagerMVC   
---
classDiagram

UglyView ..|> IView
UglyView  --> Controller
UglyView o-- Player
CompareByName ..|> IComparer
CompareByName ..> Player
Controller o-- Player
Controller --> CompareByName
Controller --> IView
Controller --> IComparer
Controller ..> PlayerOrder
Player ..|> IComparable
Program o-- Player
Program --> Controller
Program --> UglyView

<<interface>>IComparer
<<interface>>IComparable
<<interface>>IView

```