using System.Reflection;
using System;

namespace MusicAPI.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test()
    {
        
        var api = new NeteaseAPI();
        //var api = new TencentAPI();

        //����Headers
        //api.Headers = new Dictionary<string, string> { { "Addition", "12345" } /*, { "Cookie", "Yours" }*/ };

        //��������
        var search = await api.Search("Avid", limit: 5);
        var song = search[0]!;
        Console.WriteLine(song);

        //��ȡ������Ϣ
        var songInfo = await api.GetSong(song!.Id);
        Console.WriteLine(songInfo);

        //��ȡ������Դ
        var songResource = await api.GetSongResource(song!.Id);
        Console.WriteLine(songResource);

        //��ȡ���
        var songLyric = await api.GetLyric(song!.Id);
        Console.WriteLine(songLyric);

        //��ȡ����ͷͼ
        var songPicture = await api.GetPicture(song!.Id, 520);
        Console.WriteLine(songPicture);

        return;
    }
}