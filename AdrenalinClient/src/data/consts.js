export const cardItems = [
  {
    id: 1,
    img: 'giri.png',
    title: 'Современное оборудование',
    text: 'Чистые залы для тренировок с новыми тренажерами, каждый центр оборудован климатической техникой, которая поддерживает комфортную температуру во время занятий, в каждой раздевалке оборудована душевая.',
  },
  {
    id: 2,
    img: 'sila.png',
    title: 'Лучшие тренеры',
    text: 'Тренеры «Адреналин» настолько хороши, что они не только помогают вам во время занятий, но и подготавливают других тренеров.',
  },
  {
    id: 3,
    img: 'spa.png',
    title: 'SPA-кабинет',
    text: 'Наши мастера имеют медицинское и косметическое образование, более 15 лет опыта работы, постоянно повышают квалификацию, являются технологами мировых косметических брендов, прошли обучение за рубежом (Таиланд, Россия, Латвия,Франция, Испания).',
  },
  {
    id: 4,
    img: 'pool.png',
    title: 'Аквазона',
    text: 'В аквазоне вы можете отдохнуть после напряженного дня, очистить организм от токсинов или заняться спортом и аквааэробикой.',
  },
];

export const rules = [
  {
    id: 1,
    text: 'ПРАВИЛА ПОСЕЩЕНИЯ ФИТНЕС-ЦЕНТРОВ "АДРЕНАЛИН"',
    img: 'rule.png',
    pdf: 'rules.pdf',
    fileName: 'Правила посещения',
  },
  {
    id: 2,
    text: 'ПРАВИЛА БОНУСНОЙ ПРОГРАММЫ ЦЕНТРОВ "АДРЕНАЛИН"',
    img: 'rule.png',
    pdf: 'bonuses.pdf',
    fileName: 'Правила бонусной программы',
  },
];

export const clubs = [
  {
    id: 1,
    city: 'Минск',
    adress: 'ул. Максима Богдановича, 66',
    image: 'minsk_mak.png',
  },
  {
    id: 2,
    city: 'Минск',
    adress: 'ул. Маяковского, 115',
    image: 'minsk_maiak.png',
  },
  {
    id: 3,
    city: 'Минск',
    adress: 'просп. Независимости, 3/2',
    image: 'minsk_nez.png',
  },
  {
    id: 4,
    city: 'Минск',
    adress: 'ул. Академика Купревича, 18',
    image: 'minsk_acad.png',
  },
  {
    id: 5,
    city: 'Минск',
    adress: 'ул. Нёманская, 67',
    image: 'minsk_nem.png',
  },
  {
    id: 6,
    city: 'Минск',
    adress: 'просп. Победителей, 127А',
    image: 'minsk_pob.png',
  },
  {
    id: 7,
    city: 'Минск',
    adress: 'ул. Толбухина, 4',
    image: 'minsk_tol.png',
  },
];

export const news = [
  {
    id: 1,
    date: '12 Февраля 2023',
    img: 'new1.png',
    title: 'Проведение турнира Гран-при Adrenalin III ',
    text: 'Гран-при Адреналин III" - международный командный турнир по пауэрлифтингу, уникальный своим форматом будет проведен в апреле 2023 года на базе сети клубов Адреналин.',
  },
  {
    id: 2,
    date: '31 Декабря 2022',
    img: 'new2.png',
    title: 'Изменение в правилах бонусной программы - Adrenalin-Fitness',
    text: 'Изменения в правилах бонусной программы с 01.01.2023г.Пункт 3.2 Регулярные Бонусы – начисляются только за покупки абонементов в фитнес-клубах Организатора, расположенных по адресам, указанным на обратной стороне бонусной карты.',
  },
  {
    id: 3,
    date: '27 Июля 2022',
    img: 'new3.png',
    title: 'ФИТНЕС ТУР В ТУРЦИЮ ОКТЯБРЬ 2022!',
    text: 'Фитнес-тур в Турцию! Мягкие пляжи, лазурные берега и эффективные тренировки этой осенью! Предлагаем провести неделю 10-17 октября в Турции вместе с Адреналин. Подробнее можно узнать по телефону.',
  },
  {
    id: 4,
    date: '19 Апреля 2022',
    img: 'new4.png',
    title: 'Наше мобильное приложение в AppGallery - Adrenalin-Fitness',
    text: 'Уважаемые пользователи устройств Huawei и Honor, если на вашем устройстве не предустановоленны сервисы Google, не отчаивайтесь, мы не забыли о вас и выпустили мобильное приложение в AppGallery! Быстрое, удобное, полезное, с ним можно не беспокоиться о забытой дома карте абонемента.',
  },
];

const getDate = () => {
  var today = new Date();
  var dd = String(today.getDate()).padStart(2, '0');
  var mm = String(today.getMonth() + 1).padStart(2, '0');
  var yyyy = today.getFullYear();
  return dd + '/' + mm + '/' + yyyy;
};
