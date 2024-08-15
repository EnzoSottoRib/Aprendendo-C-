
//1- criar um vetor para receber os valores inteiros
//2- colocar os valores no vetor aleatoriamente
//3- ordenar os valores bubble sort
//4- printar eles ordenados

using System.Collections.Specialized;

Random random = new Random();
int[] vetor = new int[10];
for(int i = 0; i < vetor.Length; i++){
    vetor[i] = random.Next(1000);
    Console.Write(vetor[i] + " ");
}

int temp = 0;
int cont = 0;
for(int i = 0; i< vetor.Length; i++){

    for(int j=0; j<vetor.Length; j++){
        while (cont < 9){
        if(vetor[j] > vetor[j+1]){
        temp = vetor[j];
        vetor[j] = vetor[j+1];
        vetor[j+1] = temp;
    }
    cont++;
    }
    }
    
    
}

Console.Write("Ordenado ↓\n\n");
for(int i= 0; i< vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}
