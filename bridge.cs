// Implementor
public interface IRenderer
{
    void RenderCircle(float radius);
}

// Concrete Implementors
public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius) => Console.WriteLine($"Drawing a circle with radius {radius} using vectors.");
}

public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius) => Console.WriteLine($"Drawing a circle with radius {radius} using pixels.");
}

// Abstraction
public abstract class Shape
{
    protected IRenderer renderer;

    protected Shape(IRenderer renderer) => this.renderer = renderer;

    public abstract void Draw();
}

// Refined Abstraction
public class Circle : Shape
{
    private float radius;

    public Circle(IRenderer renderer, float radius) : base(renderer) => this.radius = radius;

    public override void Draw() => renderer.RenderCircle(radius);
}

// Usage
IRenderer vectorRenderer = new VectorRenderer();
Shape circle = new Circle(vectorRenderer, 5);
circle.Draw(); // Output: Drawing a circle with radius 5 using vectors.
