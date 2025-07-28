import os
import shutil

PASTA_ORIGEM = "C:/Users/Ana/Downloads"

MAPEAMENTO_PASTAS = {
    "Documentos": [".pdf", ".docx", ".txt", ".odt"],
    "Imagens": [".jpg", ".jpeg", ".png", ".gif", ".bmp", ".svg"],
    "Planilhas": [".csv", ".xlsx", ".xls"],
    "Apresentacoes": [".pptx", ".ppt"],
    "Comprimidos": [".zip", ".rar", ".7z", ".gz"],
    "Executaveis": [".exe", ".msi"],
}

PASTA_OUTROS = "Outros"

def organizar_pasta(caminho_origem):
    """
    Função principal que executa a lógica de organização.
    """
    print(f"Iniciando organização da pasta: {caminho_origem}\n")
    
    if not os.path.isdir(caminho_origem):
        print(f"Erro: O caminho '{caminho_origem}' não existe ou não é uma pasta.")
        return

    for nome_arquivo in os.listdir(caminho_origem):
        caminho_arquivo_origem = os.path.join(caminho_origem, nome_arquivo)

        if os.path.isfile(caminho_arquivo_origem):
            _, extensao = os.path.splitext(nome_arquivo)
            extensao = extensao.lower() # Converte para minúscula para garantir a correspondência

            pasta_destino_nome = PASTA_OUTROS # Padrão
            for nome_da_pasta, extensoes in MAPEAMENTO_PASTAS.items():
                if extensao in extensoes:
                    pasta_destino_nome = nome_da_pasta
                    break
            
            caminho_pasta_destino = os.path.join(caminho_origem, pasta_destino_nome)
            
            if not os.path.exists(caminho_pasta_destino):
                os.makedirs(caminho_pasta_destino)
                print(f"Pasta criada: {pasta_destino_nome}")

            caminho_arquivo_destino = os.path.join(caminho_pasta_destino, nome_arquivo)
            shutil.move(caminho_arquivo_origem, caminho_arquivo_destino)
            print(f"Moveu: '{nome_arquivo}' -> para a pasta '{pasta_destino_nome}'")

    print("\nOrganização concluída com sucesso!")

# --- Execução do Script ---
if __name__ == "__main__":
    # Mensagem de alerta para garantir que o usuário saiba o que está fazendo
    print("--- ATENÇÃO ---")
    print(f"Este script irá MOVER arquivos da pasta de origem:")
    print(f"'{PASTA_ORIGEM}'")
    print("Os arquivos serão movidos para subpastas dentro deste mesmo local.")
    
    try:
        # Pede uma confirmação antes de executar uma ação destrutiva (mover arquivos)
        resposta = input("Você tem certeza que deseja continuar? (s/n): ").lower()
        if resposta == 's' or resposta == 'sim':
            organizar_pasta(PASTA_ORIGEM)
        else:
            print("Operação cancelada pelo usuário.")
    except Exception as e:
        print(f"Ocorreu um erro inesperado: {e}")
