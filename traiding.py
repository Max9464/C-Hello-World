import openai
import telebot

openai.api_key = "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"
bot = telebot.TeleBot("6160296029:AAHj6lBVlYvuYfhZKAncG_LUcQYwERQDMCk")

@bot.message_handler(func=lambda _: True)
def handle_message(massage):
    response = openai.Completion.create(
      model="text-davinci-003",
      prompt=massage.text,
      temperature=0.5,
      max_tokens=1000,
      top_p=1.0,
      frequency_penalty=0.5,
      presence_penalty=0.0,

    )
    bot.send_message(chat_id=massage.from_user.id, text=response['choices'][0]['text'])


bot.polling()

