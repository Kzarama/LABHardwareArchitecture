%include "io.inc"

section .data
BD_A db "186976.35"
BD_B db "425731.74"
BD_C db "000000.00"

section .text
global CMAIN
CMAIN:
    mov ebp, esp; for correct debugging
    
    ;colocar las pocisiones en 0
    xor eax, eax
    xor ebx, ebx
    xor ecx, ecx
    xor edx, edx
    
    ;tamaño de los numeros
    mov ecx, 8
    
    ;suma
L18:mov al, [BD_A + ecx];tomar numero del registro
    mov bl, [BD_B + ecx];tomar numero del registro
    cmp al, '.';compara si es punto
    je L25;salta si es punto
    add al, bl;suma numeros
    AAA;arregla suma
    add al, dl;sumar carry
    AAA;arregla suma 
    
    mov dl, 0;borrar carry
    add al, 30h;sumar 30 para que se arregle el numero con cod ascii
    
    cmp ah, 0;compara si tiene carry
    je L25;salta si no tiene carry
    add dl, 1h;añade el carry a otra posicion
    mov ah, 0;borra el carry
L25:mov [BD_C + ecx], al;coloca la suma en la posicion del registro que debe ir
    dec ecx;decrementa contador
    cmp ecx, -1;compara si hay numeros en el arreglo
    jne L18;salta si hay numeros
    
    xor eax,eax
    ret