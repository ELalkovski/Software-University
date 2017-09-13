This program reads strings in format:  {personName}: {PT, PT, PT,… PT}
Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. 
The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. 
A single person cannot have more than one card with the same power and type, if he draws such a card he discards it. 
The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type. 
Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
