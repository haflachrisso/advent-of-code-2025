// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

Console.Clear();

Console.WriteLine("I am a dial. Twist and turn me right and left, with a list of rotations I wont theft!");
var rotations = File.ReadAllLines("RotationFiles/rotations.txt").ToList();
int totalRotations = SecretCodeCracker.RotationsCount(rotations);
Console.WriteLine($"Total rotations: {totalRotations}.");

