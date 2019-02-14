# Board game architecture

* How are your board game build?
The basic concept is that I have 9 buttons aligned to represent a tictactoe interface. Upon launching the application/site the game starts and every time a button is pressed. Said button gets a new value and page is reloaded with the opposing players turn. 
after each check a wincheck and drawcheck is performed.

In GameModel i have the board itself. It also contains the player

Views contains the html gui consists of buttons aligned to represent a classix 3X3 ticTacToe interface. Each button will be assigned a value based on which players turn it is to press the button.

The controller contains the actioncalls and controls which players turn it is.

GameEngine contains the logic for wincheck and draw.
