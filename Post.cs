using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  // Design a class called Post. This class models a StackOverflow post. It should have properties
  // for title, description and the date/time it was created. We should be able to up-vote or down-vote
  // a post. We should also be able to see the current vote value. In the main method, create a post,
  // up-vote and down-vote it a few times and then display the the current vote value.
  // In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
  // and down-voting. You should not give the ability to set the Vote property from the outside,
  // because otherwise, you may accidentally change the votes of a class to 0 or to a random
  // number. And this is how we create bugs in our programs. The class should always protect its
  // state and hide its implementation detail.

  // Educational tip: The aim of this exercise is to help you understand that classes should
  // encapsulate data AND behaviour around that data. Many developers (even those with years of
  // experience) tend to create classes that are purely data containers, and other classes that are
  // purely behaviour (methods) providers. This is not object-oriented programming. This is
  // procedural programming. Such programs are very fragile. Making a change breaks many parts
  // of the code.
  public class Post
  {
    private string _title { get; set; }
    private string _description { get; set; }
    private int _votes { get; set; }
    private DateTime _createdAt { get; set; }

    public Post()
    {
      _votes = 0; 
    }
    public void Upvote()
    {
      _votes ++;
    }
    public void Downvote()
    {
      _votes --;
    }
    public void Seevotes()
    {
      System.Console.WriteLine(_votes);
    }

    public static void createPost()
    {
      var myPost = new Post();
      bool loop = true;
      while (loop)
      {
        System.Console.WriteLine("Enter upvote, downvote, seevote, or end");
        string answer = Console.ReadLine();
        switch(answer)
        {
          case "upvote":
          {
            myPost.Upvote();
            break;
          }
          case "downvote":
          {
            myPost.Downvote();
            break;
          }

          case "seevote":
          {
            myPost.Seevotes();
            break;
          }
          case "end":
          {
            loop = false;
            break;
          }
          default :
          {
            break;
          }
        }
      }
    }
  }
}
