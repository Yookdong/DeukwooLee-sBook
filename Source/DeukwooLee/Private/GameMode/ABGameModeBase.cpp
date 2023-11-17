// Fill out your copyright notice in the Description page of Project Settings.


#include "GameMode/ABGameModeBase.h"

AABGameModeBase::AABGameModeBase()
{
}

void AABGameModeBase::PostLogin(APlayerController* NewPlayer)
{
	Super::PostLogin(NewPlayer);
}
