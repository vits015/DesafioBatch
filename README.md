# DesafioBatch

Aplicação desenvolvida em **C# / .NET 10** para processamento de arquivos **JSONL**, aplicação de regras de negócio e geração de arquivos **CSV**.

O caminho do arquivo de entrada é recebido como **parâmetro**, permitindo executar o programa com diferentes bases sem alterar o código.

## 🚀 Tecnologias

- C#
- .NET 10
- System.Text.Json
- JSONL
- CSV

## ▶️ Como executar

Clone o repositório e acesse a pasta:

```bash
git clone <URL_DO_REPOSITORIO>
cd DesafioBatch
```

Restaure e compile:

```bash
dotnet restore
dotnet build
```

Execute informando o caminho do arquivo JSONL:

```bash
dotnet run -- "C:\dados\clubs.jsonl"
```

Também é possível utilizar caminhos relativos:

```bash
dotnet run -- ".\input\clubs.jsonl"
```

## 📄 Entrada

O arquivo deve estar no formato **JSONL**, com um objeto JSON por linha.

Exemplo:

```json
{"ClubId":"1","Name":"Clube Exemplo","Championship":"SERIE A","FoundingDate":"01/01/1900"}
{"ClubId":"2","Name":"Outro Clube","Championship":"SERIE B","FoundingDate":"15/05/1920"}
```

## ⚙️ Processamento

A aplicação:

1. Lê o arquivo JSONL linha por linha.
2. Desserializa os registros para objetos `Club`.
3. Filtra clubes da **SERIE A** e **SERIE B**.
4. Gera os arquivos CSV de clubes e jogadores.
5. Formata as datas antes da gravação.
6. Ignora registros JSON inválidos sem interromper todo o processamento.

## 📤 Saída

Os arquivos são gerados no diretório `output`:

```text
output/
├── clubs.csv
└── players.csv
```

`clubs.csv` contém os dados dos clubes e `players.csv` contém os jogadores dos clubes processados, utilizando o `ClubId` para relacionamento.

## 🏗️ Estrutura

```text
src/DesafioBatch/
├── Models/
├── Services/
├── Utils/
└── Program.cs
```

### Principais componentes

- **Program** — inicialização da aplicação e recebimento dos parâmetros.
- **JsonlReader** — leitura e desserialização do JSONL.
- **BatchProcessor** — processamento e regras de negócio.
- **CsvWriter** — geração dos arquivos CSV.
- **DateUtils** — formatação das datas.
