//Elizar Garcia
//10-27-22
//MiniChMagic8ball
//For this project we will create a magic8ball that will generate random outputs for the user.
//Peer Review: N. HARRISON WILKINS : NICE WORK! SIMPLE CODE , VERY EASY TO DIGEST AND VERY READABLE , OVERALL GREAT WORK!!!

using Microsoft.AspNetCore.Mvc;

namespace GarciaEMagic8ballEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class BallController : ControllerBase
{
   [HttpGet]
[Route("Ball/{questions}")]

public string Game(string questions)
{
   string [] random = new string [] {"Nah Bruh", "Ask Much Much Later", "\"Rolls Eyes\"", "Like That Will Happen", "No", "Yes", "Maybe", "Maybe Poop On It", "Sleep On It", "Was That A Rhetorical Question?" }; 
    
    Random num = new Random();
    int guessNum = num.Next(0,9);
    
    
     return random[guessNum];

}
    
}
