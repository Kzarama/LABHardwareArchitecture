.386
.model flat, stdcall
option casemap : none

.data
ArrayNumbers dword 19, 21, 20, 18, 20
sum dword 0
i dword 0

.code
start:
    mov ecx, 5
L3:
    mov eax, DWORD PTR [i]
    mov eax, DWORD PTR [ArrayNumbers + eax * 4]
    add DWORD PTR [sum], eax
    inc DWORD PTR [i]
    loop L3
    
    mov ebx, [sum]
    xor eax, eax
    ret
    end start