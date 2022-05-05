using Challenge4;
using Challenge4.eiffel;
/*
Cuenta c1 = new Cuenta("guty",1000);

c1.mostrar();
c1.ingresar(200);
c1.mostrar();

c1.retirar(500);
c1.mostrar();
c1.retirar(3000);
c1.mostrar();

CuentaJoven c2 = new CuentaJoven("juan",2000,20,30);
c2.mostrar();
c2.ingresar(200);
c2.mostrar();
c2.retirar(500);
c2.mostrar();
c2.retirar(3000);
c2.mostrar();

AlbumFotos album = new SuperAlbumFotos();
Console.WriteLine(album.numPagina);
*/
Queue<int> lista = new Queue<int>();

Eiffel.cargarDatos(lista);
//Console.WriteLine(largo);
Eiffel.mostrarDatos(lista);
Console.WriteLine("///////////////");
Console.WriteLine(Eiffel.iesima(lista,5));
Console.WriteLine("///////////////");
Eiffel.mostrarDatos(lista);
