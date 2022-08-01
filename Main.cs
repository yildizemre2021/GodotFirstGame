using Godot;
using System;

public class Main : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
#pragma warning disable 649
    [Export]
    public PackedScene MobScene;
#pragma warning restore 649

    public int Score;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Randomize();   
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
