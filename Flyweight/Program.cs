using Flyweight;

Console.Title = "Flyweight";

var aBunchOfCharacters = "abba";

var characterFactory = new CharacterFactory();

// Get the flyweight(s)
var characterObject = characterFactory.GetCharacter(aBunchOfCharacters[0]);
// Pass through extrinsic state
characterObject?.Draw("Arial", 12);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[1]);
characterObject?.Draw("Trebuchet MS", 14);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[2]);
characterObject?.Draw("Times New Roman", 12);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[3]);
characterObject?.Draw("Comic Sans", 18);

// Create unshared concrete flyweight (paragraph)
var paragraph = characterFactory.CreateParagraph(
    new List<ICharacter> { characterObject! }, 1);
// Draw the paragraph
paragraph.Draw("Lucinda", 12);
