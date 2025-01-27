int number = default; // Violates the rule. Should prefer assigning 0 instead of default.
bool isActive = default; // Violates the rule. Should prefer assigning false instead of default.
string text = default; // Violates the rule. Should prefer assigning null instead of default.

Console.WriteLine($"Number: {number}, IsActive: {isActive}, Text: {text}");