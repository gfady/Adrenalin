import React from 'react';
import styles from './infocarditem.module.css';
import { cardItems } from '../../data/consts';
import InfoCardItem from './InfoCardItem';

export default function InfoCardsList() {
  return (
    <div className={styles.cardsWrapper}>
      {cardItems.map((card) => (
        <InfoCardItem key={card.id} cardItem={card}></InfoCardItem>
      ))}
    </div>
  );
}
