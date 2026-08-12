using DesafioBatch.Services;

var inputPath = "../../../input/data.jsonl";
var outputDirectory = "../../../output";

Directory.CreateDirectory(outputDirectory);

var clubsOutputPath = Path.Combine(
    outputDirectory,
    "clubs.csv");

var playersOutputPath = Path.Combine(
    outputDirectory,
    "players.csv");

var jsonlReader = new JsonlReader();
var csvWriter = new CsvWriter();

var batchProcessor = new BatchProcessor(
    jsonlReader,
    csvWriter);

batchProcessor.Process(
    inputPath,
    clubsOutputPath,
    playersOutputPath);