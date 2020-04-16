%include "io.inc"
section .data
BD_dato1 db "02000.00",0
BD_delta db "00005.02",0
iterations db 5
section .text
global CMAIN
CMAIN:
    mov ebp, esp; for correct debugging
    xor eax, eax
    xor ebx, ebx
    xor ecx, ecx
    lea esi, [BD_dato1]
    push esi
    call length
    add esp, 4
    dec ecx
    mov bx, [iterations]
for:
    push ecx
    push bx
    lea esi, [BD_dato1] ;dir operando A
    push esi
    lea edx, [BD_delta] ;dir operando B
    push edx
    lea edi, [BD_dato1] ;dir result
    push edi
    call subtract
    add esp, 12
    pop bx
    pop ecx
    dec bx
    cmp bx, 0
    jne for
    ret
;-----------------------------------------
;tamaño del arreglo de numeros
length:
    push ebp
    mov ebp, esp
    mov edi, [ebp+8]
    xor ecx, ecx
Lini:
    mov al, [edi + ecx]
    cmp al, 0
    je Fin
    inc ecx
    jne Lini
Fin:
    mov esp, ebp
    pop ebp
    ret
;-----------------------------------------
;metodo de resta
subtract:
    push ebp
    mov ebp, esp
    mov esi, [ebp+16]
    mov edx, [ebp+12]
    mov edi, [ebp+8]
L1: 
    mov al, [esi + ecx]
    mov bl, [edx + ecx]
    cmp al, '.'
    je L2
    cmp ah, 0h
    je L3
    cmp al, 30h
    jne L4
    mov al, 39h
    jmp L3
L4:
    add al, ah
    mov ah, 0h
L3: 
    sub al, bl
    aas
    add al, 30h
L2: 
    mov [edi+ecx], al
    dec ecx
    cmp ecx, -1
    jne L1
    mov esp, ebp
    pop ebp
    ret