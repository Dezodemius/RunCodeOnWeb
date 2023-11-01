using System;

namespace YCode.Core.Entities;

public class Task
{
  public Guid Id { get; }

  public string Title { get; }

  public Topic Topic { get; }

  public string Description { get; }

  public Author Author { get; }

  public string Solution { get; }
}