%include "io.inc"

section.data
BD_A db "1567.34"
BD_B db "6232.53"
BD_C db "0000.00"

section .text
global CMAIN
CMAIN:
    mov ebp, esp; for correct debugging
    ;write your code here
    xor eax, eax
    xor ebx, ebx
    xor ecx, ecx
    
    mov al, [BD_A+6]
    mov bl, [BD_B+6]
    add al. bl
    mov [BD_C+6], al
    xor eax, eax
    ret