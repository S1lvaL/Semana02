
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();


app.MapGet("/", () => {
    return new {mensagem="API em exercução ..." };
});

 app.MapGet("/calcula/soma/{a}/{b}", (double a, double b) => {
    return new { mensagem = "Soma = ", resultado = a + b };    
 });

 app.MapGet("/calcula/subtracao/{a}/{b}", (double a, double b) => {
        return new { mensagem = "Subtração = ", resultado = a - b };
 });

 app.MapGet("/calcula/multiplicao/{a}/{b}", (double a, double b) => {
    return new { mensagem = "Multiplicação = ", resultado = a * b };
 });
 app.MapGet("/calcula/divisao/{a}/{b}", (double a, double b) => {
    return new { mensagem = "divisao = ", resultado = a / b };
 });

// Inicia o servidor web é iniciado e passa a aguardar requisições HTTP dos clientes
app.Run();