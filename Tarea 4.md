# <p align = "center ">  Tarea 4</p>
### 1. Considera el siguiente fragmento de programa:
~~~csharp
using System;

class A
    {
     public int a;
     public A()
     {
      a = 10;
     }
     //public _______ string Display()
     public virtual string Display()
      {
        return a.ToString();
      }
    }
class B:A
   {
     public int b;
     public B():base()
    {
      b = 15;
    }
  public override string Display()
    {
      return b.ToString();
    }
   }

 class Program
 {
     public static void Main()
    {
     A objA = new A();
     B objB = new B();
     Console.WriteLine(objA.Display()); ////  (1 )
     Console. WriteLine(objB.Display()); ////  ( 2)
    }

  }
~~~
1.1 - **¿Qué valores imprimen las lineas (1) y (2)?**
> R = Imprimen el valor 10 en ambas lineas.

1.2. - **Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?**
> R = Imprimen los valores asignados en las clases, el 10 y el 15 respectivamente.

1.3. **¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?**
>R = Virtual.
___
## 2. Considera el siguiente fragmento de programa:
~~~c#
abstract class Musico

    {
    public string nombre;

    public Musico (string n)
    {
      nombre = n;
    }
   public abstract void Afina(); 

   public virtual string Display()
      { 
        return nombre;
      }
   }

class Bajista: Musico
  {
    public string bajo;

    public Bajista (string n, string bajo ):base(n)
    {
        this.bajo = bajo;
    }

    public override void Afina()
      {
        Console.WriteLine("Nombre: {0}, instrumento que afina: {1}",nombre,bajo);

      }
         public override string Display()
      { 
        return string.Format("Hola soy {0} y toco el {1}",nombre,bajo);
      }
 }

class Guitarrista : Musico 
     {
       public string guitarra;
     
    public Guitarrista (string n, string guitarra ):base(n)
    {
      this.guitarra = guitarra;

    }

    public override void Afina()
      {     
        Console.WriteLine("Nombre: {0}, instrumento que toca: {1}",nombre,guitarra);
      }
        public override string Display()
      { 
        return string.Format("Hola soy {0} y toco la {1}",nombre,guitarra);
      }
     }

class Program
{
  public static void Main()
  {
      //Musico m = new Musico("Django"); //(D)
      Bajista b = new Bajista("Flea","Bajo");
      Guitarrista g = new Guitarrista("Santana","guitarra");

      List<Musico> musicos = new List<Musico>();

      musicos.Add(b);
      musicos.Add(g);
      musicos.Add(new Guitarrista("Django","Segunda Guitarra"));

      Musico[] m = new Musico[2];
      m[0] = b;
      m[1] = g;

      Console.WriteLine(m[0].Display());
      Console.WriteLine(m[1].Display()+"\n");

      foreach (Musico mu in musicos)
      {
        mu.Afina();
      }
    }
  }
}
~~~
___
## 2.1. Completa el programa.

2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
> R = En el punto (D) por que no se puede crear una instancia de una clase abstracta, en este caso de la clase abstracta Musico

2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
>todos los metodos y propiedades abstractos tiene que ser implementado en las clases derivadas.

2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
> Debido a que es una clase abstracta no conlleva atributos, puede llevar cuando no lo es.

2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
>Podria ser redefinirse y no habria problema con omitirse.
___
## 1. Implementa el programa utilizando interfaces en lugar de herencia.
~~~c#
public interface IMusico
  {
    void Afina();
  }

  class Musico 
  {
    public string nombre;

    public Musico (string n)  
    { 
      nombre = n; 
    }
  }

  class Bajista: Musico, IMusico
  {
    public string bajo;

    public Bajista (string n, string bajo ):base(n)
    {
      this.bajo = bajo;
    }

    public void Afina()
    {
      Console.WriteLine("Nombre: {0}, instrumento que afina: {1}",nombre,bajo);
    }
  }

  class Guitarrista : Musico, IMusico
  {
    public string guitarra;

    public Guitarrista (string n, string guitarra ):base(n)
    {
      this.guitarra = guitarra;
    }

    public void Afina()
    {
      Console.WriteLine("Nombre: {0}, instrumento que toca: {1}",nombre,guitarra);
    }
  }

  class Program
  {
    public static void Main()
    {
      Bajista b = new Bajista("Flea","Bajo");
      Guitarrista g = new Guitarrista("Santana","guitarra");

      List<Musico> musicos = new List<Musico>();

      musicos.Add(b);
      musicos.Add(g);
      musicos.Add(new Guitarrista("Django","Segunda Guitarra"));

      foreach (Musico mu in musicos)
      {
        (mu as IMusico).Afina();
      }
    }
  }
  ~~~