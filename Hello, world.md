# Первый файл по контролю версий.

для создания крупного заголовка напечатайте в начале текста решетку в англ раскладке (#) - автоматически добавится полоса отчерка заголовка от основного текста.

## Выделение текста:
для создания некрупного заголовка/подзаголовка напечатайте в начале текста двойную решетку в англ раскладке (##) - автоматически добавится полоса отчерка заголовка/подзаголовка от основного текста.

*Курсив.* для этого обрамите текст одинарными звездочками

**Полужирный** для этого обрамите текст двойными звездочками

~~Зачеркнутый текст~~ для этого обрамите текст двойными значками "тильда" (в англ раскладке +шифт)

## Списки: (ненумерованные и нумерованные)

для первых нажимаем звездочку/минус и затем -пробел.

* Элемент 1
* Элемент 2
* Элемент 3

для вторых печатаем номер и точку, затем -пробел.

1. Первый элемент нумерованного списка.
2. Второй элемент нумерованного списка.

## Вложенные списки:
выполняем отступы:

 Номер 1

 Номер 2


# Paragraphs
To create paragraphs, use a blank line to separate one or more lines of text.

Markdown	HTML	Rendered Output
I really like using Markdown.

I think I'll use it to format all of my documents from now on.	<p>I really like using Markdown.</p>

<p>I think I'll use it to format all of my documents from now on.</p>	
I really like using Markdown.

I think I'll use it to format all of my documents from now on.

## Paragraph Best Practices
Unless the paragraph is in a list, don’t indent paragraphs with spaces or tabs.

 Note: If you need to indent paragraphs in the output, see the section on how to indent (tab).
✅  Do this	❌  Don't do this
Don't put tabs or spaces in front of your paragraphs.

Keep lines left-aligned like this.

    This can result in unexpected formatting problems.

  ### Don't add tabs or spaces in front of paragraphs.
Line Breaks
To create a line break or new line (<br>), end a line with two or more spaces, and then type return.

Markdown	HTML	Rendered Output
This is the first line.  
And this is the second line.	<p>This is the first line.<br>
And this is the second line.</p>	
This is the first line.
And this is the second line.

## Line Break Best Practices
You can use two or more spaces (commonly referred to as “trailing whitespace”) for line breaks in nearly every Markdown application, but it’s controversial. It’s hard to see trailing whitespace in an editor, and many people accidentally or intentionally put two spaces after every sentence. For this reason, you may want to use something other than trailing whitespace for line breaks. If your Markdown application supports HTML, you can use the <br> HTML tag.

###### For compatibility, use trailing white space or the <br> HTML tag at the end of the line.

There are two other options I don’t recommend using. CommonMark and a few other lightweight markup languages let you type a backslash (\) at the end of the line, but not all Markdown applications support this, so it isn’t a great option from a compatibility perspective. And at least a couple lightweight markup languages don’t require anything at the end of the line — just type return and they’ll create a line break.

✅  Do this	❌  Don't do this
First line with two spaces after.  
And the next line.

First line with the HTML tag after.<br>
And the next line.

First line with a backslash after.\
And the next line.

First line with nothing after.
And the next line.