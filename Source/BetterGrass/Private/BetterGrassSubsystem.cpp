#pragma once

#include "BetterGrassSubsystem.h"
#include "BetterGrass.h"
#include "Subsystem/ModSubsystem.h"
#include "Online.h"
#include "UObject/Object.h"

ABetterGrassSubsystem::ABetterGrassSubsystem()
{
}

void ABetterGrassSubsystem::BeginPlay()
{
	Super::BeginPlay();

	FString DensityCommand = "grass.densityscale ";
	float CustomScale = 0.0f;
	FString CustomDistanceCommand = "grass.CullDistanceScale ";
	float CustomDistance = 0.0f;

	UE_LOG(LogBetterGrass, Verbose, TEXT("Loaded Better Grass Subsystem."));
}