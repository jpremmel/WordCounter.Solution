# _Word Counter_

#### _An application to determine how many times a word appears in a sentence, 4 Oct 2019_

#### By _**Jacqueline Remmel**_

## Specifications

| Behavior | Input | Output |
| :------: | :---: | :----: |
| The program ensures that the search word is only one word | Search for "cat dog" in "I own a cat." | "Can only search for a single word; please try again." |
| The program ignores case differences between the two inputs while searching | Search for "cat" in "Cat" | "Number of times 'cat' was found: 1" |
| The program accepts two single-word inputs from the user and determines whether they are the same word | Search for "cat" in "dog" | "Number of times 'cat' was found: 0" |
| The program accepts a single word and a sentence from the user and determines how many times the word appears in the sentence | Search for "cat" in "I own a cat and you own a cat" | "Number of times 'cat' was found: 2" |
| The program accepts a single word and a sentence from the user and identifies the word regardless of punctuation surrounding the word | Search for "cat" in "I own a cat and you own a cat." | "Number of times 'cat' was found: 2" |


## Setup/Installation Requirements

* _Clone this repository and navigate to the "WordCounter.Solution" project directory_
* _Navigate to the "WordCounter" directory_
* _Run the command "dotnet restore"_
* _Run the command "dotnet run"_

## Technologies Used

_C#, .NET_

### License

*Open-source*

Copyright (c) 2019 **_Jacqueline Remmel_**