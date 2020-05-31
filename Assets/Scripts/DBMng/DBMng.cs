using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBMng
{
    /// <summary>
    /// Parametriza o jogo na primeira vez que for aberto
    /// </summary>
    public static void FirstGame(){
        if(PlayerPrefs.GetInt("FirstGame") == 0){
            PlayerPrefs.SetInt("Level_1",1);
            PlayerPrefs.SetInt("IdBodyChosen_0",1);
            PlayerPrefs.SetFloat("EffectsSound",1);
            PlayerPrefs.SetFloat("Music",1);
            PlayerPrefs.SetInt("FirstGame",1);
            PlayerPrefs.SetFloat("MouseSensibility", 50);
        }
    }
    /// <summary>
    /// Retorna o id do painel que fora salvo como ultimo aberto
    /// </summary>
    /// <returns>id fo último painel</returns>
    public static int LastPannel(){
        return PlayerPrefs.GetInt("LastPannel");
    }
    /// <summary>
    /// Retorna o volume da musica
    /// </summary>
    /// <returns>Volume da musica</returns>
    public static float MusicVolume(){
        return PlayerPrefs.GetFloat("Music");
    }
    /// <summary>
    /// Retorna o volume dos efeitos
    /// </summary>
    /// <returns>Volume dos efeitos</returns>
    public static float EffectVolume(){
        return PlayerPrefs.GetFloat("EffectsSound");
    }
    /// <summary>
    /// Retorna a sensibilidade do mouse
    /// </summary>
    /// <returns>Sensibilidade do mouse</returns>
    public static float MouseSensibility(){
        return PlayerPrefs.GetFloat("MouseSensibility");
    }
    /// <summary>
    /// Retorna o tempo gasto no level
    /// </summary>
    /// <param name="index">Index da cena</param>
    /// <returns>Tempo gasto</returns>
    public static float LevelIndexTimer(int index){
        return PlayerPrefs.GetFloat("Level_"+(index)+"_Timer");
    }
    /// <summary>
    /// Retorna a quantidade de cristal acumulado
    /// </summary>
    /// <returns>Qtd de cristal</returns>
    public static int CrystalScore(){
        return PlayerPrefs.GetInt("CrystalScore");
    }
    /// <summary>
    /// Retorna o status do personagem, se foi desbloqueado ou não
    /// </summary>
    /// <param name="idCharacter">Id do personagem</param>
    /// <returns>Status do personagem</returns>
    public static int StatusCharacter(int idCharacter){
        return PlayerPrefs.GetInt("IdBodyChosen_"+idCharacter);
    }
    /// <summary>
    /// Retorna o status do level, se foi desbloqueado ou não
    /// </summary>
    /// <param name="index">Index da cena</param>
    /// <returns>Status do level</returns>
    public static int StatusLevel(int index){
        return PlayerPrefs.GetInt("Level_"+index);
    }
    /// <summary>
    /// Retorna o Status da história, se a hisória ja foi visualizada
    /// </summary>
    /// <returns>Status da história</returns>
    public static int StatusHitory(){
        return PlayerPrefs.GetInt("History");
    }
    /// <summary>
    /// Salva o tempo gasto no level
    /// </summary>
    /// <param name="index">index da cena</param>
    /// <param name="time">Tempo gasto no level</param>
    public static void SetLevelIndexTimer(int index, float time){
        PlayerPrefs.SetFloat("Level_"+(index)+"_Timer",time);
    }
    /// <summary>
    /// Salva a quantidade de cristais
    /// </summary>
    /// <param name="value">Quantidade de cristais</param>
    public static void SetCrystalScore(int value){
        PlayerPrefs.SetInt("CrystalScore",value);
    }
    /// <summary>
    /// Desbloqueia o próximo level
    /// </summary>
    /// <param name="index">Index da cena</param>
    public static void UnlockNextLevel(int index){
        PlayerPrefs.SetInt("Level_"+(index+1),1);
    }
    /// <summary>
    /// Desbloqueia o personagem
    /// </summary>
    /// <param name="idCharacter">Id do personagem</param>
    public static void UnlockCharacter(int idCharacter){
        PlayerPrefs.SetInt("IdBodyChosen_"+idCharacter,1);
    }
    /// <summary>
    /// Retorna o personagem escolhido
    /// </summary>
    /// <returns>id do personagem escolhido</returns>
    public static int CharacterChosen(){
        return PlayerPrefs.GetInt("IdBodyChosen");
    }
    /// <summary>
    /// Seleciona o personagem
    /// </summary>
    /// <param name="idCharacter">Id do personagem</param>
    public static void SelectCharacter(int idCharacter){
        PlayerPrefs.SetInt("IdBodyChosen",idCharacter);
    }
    /// <summary>
    /// Salva o id do painel que foi aberto por ultimo antes de iniciar o level
    /// </summary>
    /// <param name="idPannel">Id do painel</param>
    public static void SetLastPannel(int idPannel){
        PlayerPrefs.SetInt("LastPannel", idPannel);
    }
    /// <summary>
    /// Informa que a história já foi visualizada
    /// </summary>
    public static void UnlockHistory(){
        PlayerPrefs.SetInt("History",1);
    }
    /// <summary>
    /// Salva a sensibilidade do mouse
    /// </summary>
    /// <param name="sensibility">Sensibilidade</param>
    public static void SetMouseSensibility(float sensibility){
        PlayerPrefs.SetFloat("MouseSensibility", sensibility);
    }
    /// <summary>
    /// Salva o volume dos efeitos sonoros
    /// </summary>
    /// <param name="volume">Volume</param>
    public static void SetEffectVolume(float volume){
        PlayerPrefs.SetFloat("EffectsSound", volume);
    }
    /// <summary>
    /// Salva o volume da musica
    /// </summary>
    /// <param name="volume"></param>
    public static void SetMusicVolume(float volume){
        PlayerPrefs.SetFloat("Music", volume);
    }
}
